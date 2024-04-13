using MediatR;

namespace msvHarmony.Application.Playlist.Command
{
    public record AgregarPlaylistCommand(string Nombre, string UsuarioId) : IRequest;
}
