using MediatR;
using msvHarmony.Domain.Ports;

namespace msvHarmony.Application.Playlist.Query
{
    public class ListarPlaylistQueryHandler : IRequestHandler<ListarPlaylistQuery, List<Domain.Entities.Playlist>>
    {
        readonly IPlaylistRepository _playlistRepository;

        public ListarPlaylistQueryHandler(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }

        public async Task<List<Domain.Entities.Playlist>> Handle(ListarPlaylistQuery request, CancellationToken cancellationToken)
        {
            var playList =  await _playlistRepository.ListarPorUsuarioAsync(request.UsuarioId);

            return (List<Domain.Entities.Playlist>)(playList.ToList() ?? Enumerable.Empty<Domain.Entities.Playlist>());
        }
    }
}
