using MediatR;

namespace msvHarmony.Application.Playlist.Command
{
    public record EliminarPlaylistDetalleCommand(string Id, string PlaylistId, string CancionId) : IRequest;
}
