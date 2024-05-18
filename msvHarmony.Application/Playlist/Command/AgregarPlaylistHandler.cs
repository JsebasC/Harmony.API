using MediatR;
using msvHarmony.Domain.Exceptions;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Application.Playlist.Command
{
    public class AgregarPlaylistHandler : AsyncRequestHandler<AgregarPlaylistCommand>
    {
        private readonly IPlaylistRepository _playlistRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AgregarPlaylistHandler(IPlaylistRepository playlistRepository, IUnitOfWork unitOfWork)
        {
            _playlistRepository = playlistRepository;
            _unitOfWork = unitOfWork;
        }

        protected override async Task Handle(AgregarPlaylistCommand request, CancellationToken cancellationToken)
        {
            var playlistPorUsuario = await _playlistRepository.ListarPorUsuarioAsync(request.UsuarioId);
            if (playlistPorUsuario.Any(playlist => playlist.Nombre == request.Nombre))
            {
                throw new CoreBusinessException("Ya existe una playlist con ese nombre");
            }

            var playlist = new Domain.Entities.Playlist()
            {
                Nombre = request.Nombre,
                UsuarioId = request.UsuarioId
            };

            await _playlistRepository.AgregarAsync(playlist);
            await _unitOfWork.SaveAsync();
        }
    }
}
