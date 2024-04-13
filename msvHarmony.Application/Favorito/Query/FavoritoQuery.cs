using MediatR;
using msvHarmony.Application.Favorito.Dto;

namespace msvHarmony.Application.Favorito.Query
{
    public record FavoritoQuery(string UsuarioId) : IRequest<List<FavoritoDto>>;
}
