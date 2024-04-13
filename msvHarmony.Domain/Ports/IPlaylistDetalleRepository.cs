using msvHarmony.Domain.Entities;

namespace msvHarmony.Domain.Ports
{
    public interface IPlaylistDetalleRepository
    {
        Task AgregarAsync(PlaylistDetalle playlistDetalle);
        void EliminarAsync(PlaylistDetalle playlistDetalle);
        Task<IEnumerable<PlaylistDetalle>> ListarDetallePorPlaylistAsync(string playlistId);
    }
}
