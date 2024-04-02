namespace msvHarmony.Domain.Ports;
public interface IUnitOfWorkSecurityDbContext : IDisposable
{
    Task<int> SaveAsync();    
}
