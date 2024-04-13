using MediatR;
using msvHarmony.Domain.Dto;
using msvHarmony.Domain.Services;

namespace msvHarmony.Application.Playlist.Query
{
    public class ListarPlaylistDetalleQueryHandler : IRequestHandler<ListarPlaylistDetalleQuery, List<PlaylistDetalleDto>>
    {
        readonly PlaylistService _playlistService;

        public ListarPlaylistDetalleQueryHandler(PlaylistService playlistService)
        {
            _playlistService = playlistService;
        }

        public async Task<List<PlaylistDetalleDto>> Handle(ListarPlaylistDetalleQuery request, CancellationToken cancellationToken)
        {
            var playListDetalle = await _playlistService.ListarPorPlaylistAsync(request.PlaylistId);

            return (List<PlaylistDetalleDto>)(playListDetalle.ToList() ?? Enumerable.Empty<PlaylistDetalleDto>());
        }
    }
}
