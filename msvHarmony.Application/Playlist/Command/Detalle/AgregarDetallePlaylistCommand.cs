using MediatR;

namespace msvHarmony.Application.Playlist.Command.Detalle
{
    public record AgregarDetallePlaylistCommand(string PlaylistId, string CancionId) : IRequest;
}
