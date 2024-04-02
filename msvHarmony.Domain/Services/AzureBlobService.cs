using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace msvHarmony.Domain.Services
{
    public class AzureBlobService
    {
        private readonly BlobServiceClient _blobClient;
        readonly BlobContainerClient _containerClient;        

        public AzureBlobService(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("storageConnection");

            _blobClient = new BlobServiceClient(connectionString);
            _containerClient = _blobClient.GetBlobContainerClient("profile-images");
        }

        public async Task<List<Azure.Response<BlobContentInfo>>> UploadFileAsync(IFormFile file, string userId)
        {
            var azureResponse = new List<Azure.Response<BlobContentInfo>>();

            await DeleteImageUserExist(file, userId);

            using var memoryStream = new MemoryStream();

            await file.CopyToAsync(memoryStream);

            using var image = Image.Load(memoryStream.ToArray());

            var maxWidth = 460;
            var maxHeight = 460;

            if (image.Width > maxWidth || image.Height > maxHeight)
            {
                var ratioX = (double)maxWidth / image.Width;
                var ratioY = (double)maxHeight / image.Height;
                var ratio = Math.Min(ratioX, ratioY);

                var newWidth = (int)(image.Width * ratio);
                var newHeight = (int)(image.Height * ratio);

                image.Mutate(x => x.Resize(newWidth, newHeight));
            }

            memoryStream.Position = 0;
            image.Save(memoryStream, new SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder { Quality = 80 });

            string blobName = $"{userId}/{file.FileName}";
            memoryStream.Position = 0;
            var client = await _containerClient.UploadBlobAsync(blobName, memoryStream, default);
            azureResponse.Add(client);

            return azureResponse;
        }

        private async Task DeleteImageUserExist(IFormFile file, string userId)
        {
            var existingBlob = await _containerClient.GetBlobClient($"{userId}/{file.FileName}").ExistsAsync();
            if (existingBlob.Value)
            {
                await _containerClient.GetBlobClient($"{userId}/{file.FileName}").DeleteIfExistsAsync();
            }
        }

        public async Task<List<BlobItem>> GetUploadedBlobs()
        {
            var items = new List<BlobItem>();
            var uploadedFiles = _containerClient.GetBlobsAsync();
            await foreach (BlobItem file in uploadedFiles)
            {
                items.Add(file);
            }

            return items;
        }
    }
}
