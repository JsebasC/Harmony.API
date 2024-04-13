using MediatR;
using msvHarmony.Domain.Dto;
using msvHarmony.Domain.Services;

namespace msvHarmony.Application.Album.Query
{
    public class AlbumQueryHandler : IRequestHandler<AlbumQuery, List<AlbumDto>>
    {
        readonly AlbumService _albumService;

        public AlbumQueryHandler(AlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<List<AlbumDto>> Handle(AlbumQuery request, CancellationToken cancellationToken)
        {
            return await _albumService.ListarAlbumnesAsync();
        }
    }
}
