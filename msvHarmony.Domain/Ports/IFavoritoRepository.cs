using msvHarmony.Domain.Entities;

namespace msvHarmony.Domain.Ports
{
    public interface IFavoritoRepository
    {
        Task AgregarAsync(Favorito favorito);
        Task<IEnumerable<Favorito>> ListarPorUsuarioAsync(string usuarioId);
        void EliminarAsync(Favorito favorito);
    }
}
