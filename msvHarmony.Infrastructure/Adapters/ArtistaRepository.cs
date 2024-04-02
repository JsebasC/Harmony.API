using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;
using msvHarmony.Infrastructure.Ports;

namespace msvHarmony.Infrastructure.Adapters
{
    [Repository]
    public class ArtistaRepository : IArtistaRepository
    {
        readonly IRepository<Artista> _dataSource;
        public ArtistaRepository(IRepository<Artista> dataSource) => _dataSource = dataSource
               ?? throw new ArgumentNullException(nameof(dataSource));

        public async Task<IEnumerable<Artista>> ListarAsync() => await _dataSource.GetManyAsync();
        public async Task<Artista> ObtenerPorIdAsync(Guid uid) => await _dataSource.GetOneAsync(uid);
    }
}
