using msvHarmony.Domain.Entities;

namespace msvHarmony.Domain.Ports
{
    public interface IArtistaRepository
    {
        Task<IEnumerable<Artista>> ListarAsync();
        Task<Artista> ObtenerPorIdAsync(Guid uid);
    }
}
