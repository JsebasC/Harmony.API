using MediatR;
using msvHarmony.Domain.Dto;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Application.Artista.Query
{
    public class ArtistaSimpleQueryHandler : IRequestHandler<ArtistaSimpleQuery, List<ArtistaDto>>
    {
        private readonly IArtistaRepository _artistaRepository;

        public ArtistaSimpleQueryHandler(IArtistaRepository artistaRepository)
        {
            _artistaRepository = artistaRepository;
        }

        public async Task<List<ArtistaDto>> Handle(ArtistaSimpleQuery request, CancellationToken cancellationToken)
        {
            var artistas = await _artistaRepository.ListarAsync();

            var artistasDto = artistas.Select(artista => new ArtistaDto
            {                
                Id = artista.Id,
                Nombre = artista.Nombre                
            }).ToList();

            return artistasDto;
        }
    }
}
