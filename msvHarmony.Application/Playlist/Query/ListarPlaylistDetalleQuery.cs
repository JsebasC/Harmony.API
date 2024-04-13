using MediatR;
using msvHarmony.Domain.Dto;

namespace msvHarmony.Application.Playlist.Query
{
    public record ListarPlaylistDetalleQuery(string PlaylistId) : IRequest<List<PlaylistDetalleDto>>;
}
