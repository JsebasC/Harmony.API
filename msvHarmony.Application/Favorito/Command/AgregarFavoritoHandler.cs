using MediatR;
using msvHarmony.Domain.Exceptions;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Application.Favorito.Command
{
    public class AgregarFavoritoHandler : AsyncRequestHandler<AgregarFavoritoCommand>
    {
        private readonly IFavoritoRepository _favoritoRepository;
        private readonly IUnitOfWork _unitOfWork;
        public AgregarFavoritoHandler(IFavoritoRepository favorito, IUnitOfWork unitOfWork)
        {
            _favoritoRepository = favorito;
            _unitOfWork = unitOfWork;
        }

        protected override async Task Handle(AgregarFavoritoCommand request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Favorito> favoritosPorUsuario = await _favoritoRepository.ListarPorUsuarioAsync(request.UsuarioId);

            if(favoritosPorUsuario.Where(favorito => favorito.CancionId == Guid.Parse(request.CancionId)).Any())
            {
                throw new CoreBusinessException("La cancion ya existe en favoritos");
            }

            var favorito = new Domain.Entities.Favorito()
            {
                UsuarioId = request.UsuarioId,
                CancionId = Guid.Parse(request.CancionId)
            };

            

            await _favoritoRepository.AgregarAsync(favorito);
            await _unitOfWork.SaveAsync();
        }
    }
}
