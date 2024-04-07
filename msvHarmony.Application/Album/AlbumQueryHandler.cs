using MediatR;
using msvHarmony.Domain.Dtos;
using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Services;
using msvHarmony.Infrastructure.Ports;

namespace msvHarmony.Application.Album
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
