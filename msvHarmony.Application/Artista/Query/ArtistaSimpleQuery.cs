using MediatR;
using msvHarmony.Domain.Dtos;

namespace msvHarmony.Application.Artista.Query
{
    public record ArtistaSimpleQuery() : IRequest<List<ArtistaDto>>;
}
