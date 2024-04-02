using MediatR;
using msvHarmony.Domain.Dtos;

namespace msvHarmony.Application.Account.Query
{
    public record AccountSimpleQuery(Guid uid) : IRequest<UserDto>;
}
