using MediatR;
using msvHarmony.Domain.Dto;

namespace msvHarmony.Application.Canciones.Query
{
    public record CancionQuery() : IRequest<List<CancionDto>>;
}
