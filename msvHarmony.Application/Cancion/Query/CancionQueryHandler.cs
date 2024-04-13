using MediatR;
using msvHarmony.Domain.Dto;
using msvHarmony.Domain.Services;

namespace msvHarmony.Application.Canciones.Query
{
    public class CancionQueryHandler : IRequestHandler<CancionQuery, List<CancionDto>>
    {
        private readonly CancionService _cancionService;

        public CancionQueryHandler(CancionService repository)
        {
            _cancionService = repository;
        }

        public async Task<List<CancionDto>> Handle(CancionQuery request, CancellationToken cancellationToken)
        {
            var canciones = await _cancionService.ListarCancionesAsync();

            return canciones;
        }

    }
}
