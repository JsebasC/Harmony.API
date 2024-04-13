using msvHarmony.Domain.Entities;

namespace msvHarmony.Domain.Ports
{
    public interface IPlaylistRepository
    {
        Task AgregarAsync(Playlist playlist);
        void EliminarAsync(Playlist playlist);      
        Task<Playlist?> ListarPorIdAsync(string playlistId);
        Task<IEnumerable<Playlist>> ListarPorUsuarioAsync(string usuarioId);        
    }
}
