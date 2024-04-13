using msvHarmony.Domain.Dto;
using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Domain.Services
{
    [DomainService]
    public class PlaylistService
    {
        readonly IPlaylistDetalleRepository _playlistDetalleRepository;
        readonly CancionService _cancionService;
        private IEnumerable<Colaboracion> colaboraciones;

        public PlaylistService(IPlaylistDetalleRepository playlistDetalleRepository, CancionService cancionService)
        {
            _playlistDetalleRepository = playlistDetalleRepository;
            _cancionService = cancionService;
        }

        public async Task<List<PlaylistDetalleDto>> ListarPorPlaylistAsync(string playlistId)
        {
            await _cancionService.ListarArtistasAsync();
            colaboraciones = await _cancionService.ListarColaboracionesAsync();
            IEnumerable<PlaylistDetalle> playlistDetalles = await _playlistDetalleRepository.ListarDetallePorPlaylistAsync(playlistId);

            if (playlistDetalles is null)
                return new List<PlaylistDetalleDto>();

            var playlistDetalleDto = playlistDetalles.Select(detalle => new PlaylistDetalleDto
            {

                Id = detalle.Id.ToString(),
                PlaylistId = detalle.PlaylistId.ToString(),
                Cancion = ObtenerCancion(detalle.Cancion)
            }).ToList();

            return playlistDetalleDto;
        }

        private CancionDto ObtenerCancion(Cancion cancion)
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
