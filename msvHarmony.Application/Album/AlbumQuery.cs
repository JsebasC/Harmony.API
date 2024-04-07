using MediatR;
using msvHarmony.Domain.Dtos;

namespace msvHarmony.Application.Album
{
    public record AlbumQuery() : IRequest<List<AlbumDto>>;
}
