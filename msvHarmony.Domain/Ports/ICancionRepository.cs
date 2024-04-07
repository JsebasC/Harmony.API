using msvHarmony.Domain.Entities;

namespace msvHarmony.Domain.Ports
{
    public interface ICancionRepository
    {
        Task<IEnumerable<Cancion>> ListarAsync();
    }
}
