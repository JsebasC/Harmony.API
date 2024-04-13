using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;
using msvHarmony.Infrastructure.Ports;

namespace msvHarmony.Infrastructure.Adapters
{
    [Repository]
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly IRepository<Playlist> _dataSource;        

        public PlaylistRepository(IRepository<Playlist> dataSource)
        {
            _dataSource = dataSource ?? throw new ArgumentNullException(nameof(dataSource));            
        }

        public async Task AgregarAsync(Playlist playlist)
        {
            await _dataSource.AddAsync(playlist);
        }

        public void EliminarAsync(Playlist playlist)
        {
            _dataSource.DeleteAsync(playlist);
        }

        public async Task<Playlist?> ListarPorIdAsync(string playlistId)
        {
            var includeProperties = "PlaylistDetalles";

            var listar =  await _dataSource.GetManyAsync(filter => filter.Id == Guid.Parse(playlistId), null, includeProperties);

            return listar.FirstOrDefault();
        }

        public async Task<IEnumerable<Playlist>> ListarPorUsuarioAsync(string usuarioId)
        {
            var includeProperties = "PlaylistDetalles";

            return await _dataSource.GetManyAsync(filter => filter.UsuarioId == usuarioId, null, includeProperties);
        }
    }
}
