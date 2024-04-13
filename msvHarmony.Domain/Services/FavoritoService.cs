using msvHarmony.Application.Favorito.Dto;
using msvHarmony.Domain.Dto;
using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Domain.Services
{
    [DomainService]
    public class FavoritoService
    {
        readonly IFavoritoRepository _favoritoRepository;
        readonly CancionService _cancionService;
        private IEnumerable<Colaboracion> colaboraciones;

        public FavoritoService(IFavoritoRepository favoritoRepository, CancionService cancionService)
        {
            _favoritoRepository = favoritoRepository;
            _cancionService = cancionService;
        }

        public async Task<List<FavoritoDto>> ListarPorUsuarioAsync(string usuarioId)
        {
            await _cancionService.ListarArtistasAsync();
            colaboraciones = await _cancionService.ListarColaboracionesAsync();
            IEnumerable<Favorito> favoritosPorUsuario = await _favoritoRepository.ListarPorUsuarioAsync(usuarioId);

            if (favoritosPorUsuario is null)
                return new List<FavoritoDto>();

            var favoritoDto = favoritosPorUsuario.Select(favorito => new FavoritoDto
            {

                Id = favorito.Id.ToString(),
                UsuarioId = favorito.UsuarioId,
                Cancion = ObtenerCancionAsync(favorito.Cancion)
            }).ToList();

            return favoritoDto;
        }

        private CancionDto ObtenerCancionAsync(Cancion cancion)
        {
            CancionDto cancionDto = new()
            {
                Id = cancion.Id.ToString(),
                Portada = cancion.Portada!,
                Nombre = cancion.Nombre,
                AlbumId = cancion.AlbumId.ToString(),
                Album = cancion.Album.Titulo,
                Artista = _cancionService.ObtenerNombreArtistaColaborador(cancion, colaboraciones),
                Duracion = _cancionService.SegundosAMinutos(cancion.Duracion),
                Source = cancion.Source!
            };

            return cancionDto;
        }
    }
}
