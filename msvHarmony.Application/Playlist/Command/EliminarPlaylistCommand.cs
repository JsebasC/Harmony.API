using MediatR;

namespace msvHarmony.Application.Playlist.Command
{
    public record EliminarPlaylistCommand(string Id, string UsuarioId) : IRequest;
}
