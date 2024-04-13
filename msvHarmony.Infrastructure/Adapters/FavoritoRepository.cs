using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;
using msvHarmony.Infrastructure.Ports;

namespace msvHarmony.Infrastructure.Adapters
{
    [Repository]
    public class FavoritoRepository : IFavoritoRepository
    {
        private readonly IRepository<Favorito> _dataSource;

        public FavoritoRepository(IRepository<Favorito> dataSource)
        {
            _dataSource = dataSource ?? throw new ArgumentNullException(nameof(dataSource));
        }

        public async Task AgregarAsync(Favorito favorito)
        {
            await _dataSource.AddAsync(favorito);
        }

        public void EliminarAsync(Favorito favorito)
        {
            _dataSource.DeleteAsync(favorito);
        }

        public async Task<IEnumerable<Favorito>> ListarPorUsuarioAsync(string usuarioId)
        {
            var includeProperties = "Cancion.Album";

            return await _dataSource.GetManyAsync(filter => filter.UsuarioId == usuarioId, null, includeProperties);
        }
    }
}
