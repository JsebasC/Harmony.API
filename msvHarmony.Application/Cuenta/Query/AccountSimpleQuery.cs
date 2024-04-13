using MediatR;
using msvHarmony.Application.Dto;

namespace msvHarmony.Application.Account.Query
{
    public record AccountSimpleQuery(Guid uid) : IRequest<UserDto>;
}
