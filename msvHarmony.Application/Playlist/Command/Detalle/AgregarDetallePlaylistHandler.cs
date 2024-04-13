using MediatR;
using msvHarmony.Domain.Exceptions;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Application.Playlist.Command.Detalle
{
    public class AgregarDetallePlaylistHandler : AsyncRequestHandler<AgregarDetallePlaylistCommand>
    {
        private readonly IPlaylistDetalleRepository _playlistDetalleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AgregarDetallePlaylistHandler(IPlaylistDetalleRepository playlistRepository, IUnitOfWork unitOfWork)
        {
            _playlistDetalleRepository = playlistRepository;
            _unitOfWork = unitOfWork;
        }

        protected override async Task Handle(AgregarDetallePlaylistCommand request, CancellationToken cancellationToken)
        {
            var playlistPorCabecera = await _playlistDetalleRepository.ListarDetallePorPlaylistAsync(request.PlaylistId);

            if (playlistPorCabecera.Where(detalle => detalle.CancionId == Guid.Parse(request.CancionId)).Any())
            {
                throw new CoreBusinessException("Ya existe la canción en la playlist");
            }

            var playlistDetalle = new Domain.Entities.PlaylistDetalle()
            {
                PlaylistId = Guid.Parse(request.PlaylistId),
                CancionId = Guid.Parse(request.CancionId)
            };

            await _playlistDetalleRepository.AgregarAsync(playlistDetalle);
            await _unitOfWork.SaveAsync();
        }
    }
}
