using msvHarmony.Domain.Entities;

namespace msvHarmony.Domain.Ports
{
    public interface IUserRepository
    {        
        Task<User> SingleUser(Guid uid);
        void UpdateUser(User user);

    }
}
