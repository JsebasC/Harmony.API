using MediatR;
using msvHarmony.Domain.Dto;

namespace msvHarmony.Application.Artista.Query
{
    public record ArtistaSimpleQuery() : IRequest<List<ArtistaDto>>;
}
