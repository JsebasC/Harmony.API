using Microsoft.EntityFrameworkCore;
using msvHarmony.Domain.Ports;
using msvHarmony.Security.Apdaters;
using msvHarmony.Security.DataSource;
using Newtonsoft.Json.Linq;

namespace msvHarmony.Infrastructure.Adapters
{
    public class UnitOfWorkSecurityDbContext : IUnitOfWorkSecurityDbContext
    {
        private readonly SecurityDbContext _context;
        public SecurityDbContext SecurityDbContext => _context;

        public UnitOfWorkSecurityDbContext(SecurityDbContext context)
        {
            _context = context;            
        }

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
