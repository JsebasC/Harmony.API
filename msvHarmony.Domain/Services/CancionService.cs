using msvHarmony.Domain.Dtos;
using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;
using msvHarmony.Infrastructure.Ports;

namespace msvHarmony.Domain.Services
{
    [DomainService]
    public class CancionService
    {
        readonly ICancionRepository _cancionRepository;
        readonly IRepository<Colaboracion> _colaboracionRepository;
        readonly IRepository<Artista> _artistaRepository;
        private IEnumerable<Artista> artistas;

        public CancionService(ICancionRepository cancionRepository,
            IRepository<Colaboracion> colaboracionRepository, IRepository<Artista> artistaRepository)
        {
            _cancionRepository = cancionRepository;
            _colaboracionRepository = colaboracionRepository;
            _artistaRepository = artistaRepository;
        }

        public async Task<List<CancionDto>> ListarCancionesAsync()
        {
            artistas = await ListarArtistasAsync();
            var colaboraciones = await ListarColaboracionesAsync();
            var canciones = await _cancionRepository.ListarAsync();

            var cancionesDto = canciones.Select(cancion => new CancionDto
            {
                Id = cancion.Id.ToString(),
                Portada = cancion.Portada!,
                Nombre = cancion.Nombre,
                AlbumId = cancion.AlbumId.ToString(),
                Album = cancion.Album.Titulo,
                Artista = ObtenerNombreArtistaColaborador(cancion, colaboraciones),
                Duracion = SegundosAMinutos(cancion.Duracion),
                Source = cancion.Source
            }).ToList();

            return cancionesDto;
        }

        public async Task<IEnumerable<Colaboracion>> ListarColaboracionesAsync()
        {
            var includeProperties = "Cancion";
            return await _colaboracionRepository.GetManyAsync(null, null, includeProperties);
        }

        public async Task<IEnumerable<Artista>> ListarArtistasAsync()
        {
            return await _artistaRepository.GetManyAsync();
        }

        string ObtenerNombreArtistaColaborador(Cancion cancion, IEnumerable<Colaboracion> colaboraciones)
        {
            var colaboracionesDeCancion = colaboraciones.Where(c => c.CancionId == cancion.Id).ToList();
            if (colaboracionesDeCancion.Any())
            {
                var nombresArtistas = colaboracionesDeCancion.Select(colaboracion =>
                {
                    var artistaColaborador = artistas.FirstOrDefault(a => a.Id == colaboracion.ArtistaId);
                    return artistaColaborador != null ? artistaColaborador.Nombre : null;

                }).Where(nombre => nombre != null).ToList();

                if (nombresArtistas.Any())
                {
                    return string.Join(", ", nombresArtistas);
                }
            }
            return string.Empty;
        }

        static string SegundosAMinutos(int segundos)
        {
            int minutos = segundos / 60;
            int segundosRestantes = segundos % 60;
            return $"{minutos:00}:{segundosRestantes:00}";
        }

    }
}
