using MediatR;
using msvHarmony.Domain.Exceptions;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Application.Playlist.Command
{
    public class EliminarPlaylistHandler : AsyncRequestHandler<EliminarPlaylistCommand>
    {
        private readonly IPlaylistRepository _playlistRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EliminarPlaylistHandler(IPlaylistRepository playlistRepository, IUnitOfWork unitOfWork)
        {
            _playlistRepository = playlistRepository;
            _unitOfWork = unitOfWork;
        }

        protected override async Task Handle(EliminarPlaylistCommand request, CancellationToken cancellationToken)
        { 
            var playlistPorId = await _playlistRepository.ListarPorIdAsync(request.Id);

            if (playlistPorId.PlaylistDetalles.Any())
            {
                throw new CoreBusinessException("Elimina primero las canciones asociadas a la playlist");
            }

            var playlist = new Domain.Entities.Playlist()
            {
                Id = Guid.Parse(request.Id),
                UsuarioId = request.UsuarioId
            };

            _playlistRepository.EliminarAsync(playlist);
            await _unitOfWork.SaveAsync();
        }
    }
}
