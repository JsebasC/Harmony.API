using MediatR;
using msvHarmony.Domain.Dto;

namespace msvHarmony.Application.Album.Query
{
    public record AlbumQuery() : IRequest<List<AlbumDto>>;
}
