using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;
using msvHarmony.Infrastructure.Ports;
using System.Linq.Expressions;

namespace msvHarmony.Infrastructure.Adapters
{
    [Repository]
    public class CancionRepository : ICancionRepository
    {
        readonly IRepository<Cancion> _dataSource;

        public CancionRepository(IRepository<Cancion> dataSource) => _dataSource = dataSource
              ?? throw new ArgumentNullException(nameof(dataSource));

        public async Task<IEnumerable<Cancion>> ListarAsync()
        {
            var includeProperties = "Album";

            return await _dataSource.GetManyAsync(null, null, includeProperties);
        }
    }
}
