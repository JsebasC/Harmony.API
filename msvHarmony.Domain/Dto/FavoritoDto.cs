using msvHarmony.Domain.Dto;

namespace msvHarmony.Application.Favorito.Dto
{
    public class FavoritoDto
    {
        public string Id { get; set; }
        public string UsuarioId { get; set; }
        public CancionDto Cancion { get; set; }

    }
}
