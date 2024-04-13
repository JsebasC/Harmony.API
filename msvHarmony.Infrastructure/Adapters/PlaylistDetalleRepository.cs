using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;
using msvHarmony.Infrastructure.Ports;

namespace msvHarmony.Infrastructure.Adapters
{
    [Repository]
    public class PlaylistDetalleRepository : IPlaylistDetalleRepository
    {        
        private readonly IRepository<PlaylistDetalle> _dataSourceDetalle;

        public PlaylistDetalleRepository( IRepository<PlaylistDetalle> dataSourceDetalle)
        {            
            _dataSourceDetalle = dataSourceDetalle ?? throw new ArgumentNullException(nameof(dataSourceDetalle));
        }
       
        public async Task AgregarAsync(PlaylistDetalle playlistDetalle)
        {
            await _dataSourceDetalle.AddAsync(playlistDetalle);
        }

        public void EliminarAsync(PlaylistDetalle playlistDetalle)
        {
            _dataSourceDetalle.DeleteAsync(playlistDetalle);
        }

        public async Task<IEnumerable<PlaylistDetalle>> ListarDetallePorPlaylistAsync(string playlistId)
        {
            var includeProperties = "Cancion.Album";
            
            return await _dataSourceDetalle.GetManyAsync(filter => filter.PlaylistId == Guid.Parse(playlistId), null, includeProperties);
        }
    }
}
