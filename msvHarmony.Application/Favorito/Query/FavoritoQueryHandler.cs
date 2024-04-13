using MediatR;
using msvHarmony.Application.Favorito.Dto;
using msvHarmony.Domain.Services;

namespace msvHarmony.Application.Favorito.Query
{
    public class FavoritoQueryHandler : IRequestHandler<FavoritoQuery, List<FavoritoDto>>
    {
        private readonly FavoritoService _favoritoService;

        public FavoritoQueryHandler(FavoritoService favoritoService)
        {
            _favoritoService = favoritoService;
        }

        public async Task<List<FavoritoDto>> Handle(FavoritoQuery request, CancellationToken cancellationToken)
        {
            var favoritos = await _favoritoService.ListarPorUsuarioAsync(request.UsuarioId);

            return favoritos;
        }
    }
}
