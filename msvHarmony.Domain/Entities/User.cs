using Microsoft.AspNetCore.Identity;
using msvHarmony.Domain.Exceptions;

namespace msvHarmony.Domain.Entities
{

    public class User : IdentityUser
    {
        private readonly string[] allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Photo { get; set; }

        public void ValidatePhoto(Microsoft.AspNetCore.Http.IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
                throw new CoreBusinessException("No se ha proporcionado ningún archivo.");

            var extension = Path.GetExtension(photo.FileName);

            if (!allowedExtensions.Contains(extension.ToLower()))
                throw new CoreBusinessException("El archivo proporcionado no es una imagen válida.");

            Photo = photo.FileName;
        }
    }
}
