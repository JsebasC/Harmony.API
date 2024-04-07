using msvHarmony.Domain.Dtos;
using msvHarmony.Domain.Entities;
using msvHarmony.Infrastructure.Ports;

namespace msvHarmony.Domain.Services
{
    [DomainService]
    public class AlbumService
    {
        readonly IRepository<Album> _repository;
        readonly CancionService cancionService;
        private List<CancionDto> canciones;

        public AlbumService(IRepository<Album> repository, CancionService cancionService)
        {
            _repository = repository;
            this.cancionService = cancionService;
        }

        public async Task<List<AlbumDto>> ListarAlbumnesAsync()
        {
            var includeProperties = "Genero,Artista,Discografica";
            var albumnes = await _repository.GetManyAsync(null, null, includeProperties);
            canciones = await cancionService.ListarCancionesAsync();

            var albumnesDto = albumnes.Select(album => new AlbumDto
            {
                Id = album.Id.ToString(),
                Portada = album.Portada,
                Titulo = album.Titulo,
                Anio = album.Anio,
                Genero = album.Genero.Nombre,
                Artista = album.Artista.Nombre,
                Discografica = album.Discografica.Nombre,
                Canciones = ObtenerCancionesAsync(album)
            }).ToList();

            return albumnesDto.ToList();
        }

        private List<CancionDto> ObtenerCancionesAsync(Album album)
        {
            var cancionesAlbumDto = new List<CancionDto>();
            
            if (canciones.Any())
            {
                var cancionesAlbum = canciones.Where(cancion => cancion.AlbumId == album.Id.ToString()).ToList();

                foreach (var item in cancionesAlbum)
                {
                    cancionesAlbumDto.Add(item);
                }                
            }

            return cancionesAlbumDto;
        }
    }
}
