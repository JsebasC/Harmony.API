using MediatR;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Application.Playlist.Command
{
    public class EliminarPlaylistDetalleHandler : AsyncRequestHandler<EliminarPlaylistDetalleCommand>
    {
        private readonly IPlaylistDetalleRepository _playlistRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EliminarPlaylistDetalleHandler(IPlaylistDetalleRepository playlistRepository, IUnitOfWork unitOfWork)
        {
            _playlistRepository = playlistRepository;
            _unitOfWork = unitOfWork;
        }

        protected override async Task Handle(EliminarPlaylistDetalleCommand request, CancellationToken cancellationToken)
        {    
            var playlistDetalle = new Domain.Entities.PlaylistDetalle()
            {
                Id = Guid.Parse(request.Id),
                PlaylistId = Guid.Parse(request.PlaylistId),
                CancionId = Guid.Parse(request.CancionId)
            };

            _playlistRepository.EliminarAsync(playlistDetalle);
            await _unitOfWork.SaveAsync();
        }
    }
}
