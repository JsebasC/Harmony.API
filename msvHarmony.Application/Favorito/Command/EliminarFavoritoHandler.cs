using MediatR;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Application.Favorito.Command
{
    public class EliminarFavoritoHandler : AsyncRequestHandler<EliminarFavoritoCommand>
    {
        readonly IFavoritoRepository _favoritoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EliminarFavoritoHandler(IFavoritoRepository favoritoRepository, IUnitOfWork unitOfWork)
        {
            _favoritoRepository = favoritoRepository;
            _unitOfWork = unitOfWork;
        }

        protected override async Task Handle(EliminarFavoritoCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Favorito favorito = new ()
            {
                Id = Guid.Parse(request.FavoritoId),
                UsuarioId = request.UsuarioId,                
            };

            _favoritoRepository.EliminarAsync(favorito);
            await _unitOfWork.SaveAsync();
        }
    }
}
