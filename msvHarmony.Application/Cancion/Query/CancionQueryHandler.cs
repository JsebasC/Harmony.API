using MediatR;
using msvHarmony.Domain.Dtos;
using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Ports;
using msvHarmony.Domain.Services;
using msvHarmony.Infrastructure.Ports;

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
