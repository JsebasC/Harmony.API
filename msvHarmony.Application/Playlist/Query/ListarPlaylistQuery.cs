using MediatR;

namespace msvHarmony.Application.Playlist.Query
{
    public record ListarPlaylistQuery(string UsuarioId) : IRequest<List<Domain.Entities.Playlist>>;
}
