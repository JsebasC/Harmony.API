using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;
using msvHarmony.Infrastructure.Adapters;
using msvHarmony.Infrastructure.Ports;

namespace msvHarmony.Security.Apdaters
{
    [RepositorySecurity]
    public class UserRepository : IUserRepository
    {
        private readonly IRepositorySecurity<User> _dataSource;

        public UserRepository(IRepositorySecurity<User> dataSource) => _dataSource = dataSource
            ?? throw new ArgumentNullException(nameof(dataSource));

        public async Task<User> SingleUser(Guid uid) => await _dataSource.GetOneAsync(uid);

        public void UpdateUser(User user) => _dataSource.UpdateAsync(user);
    }
}
