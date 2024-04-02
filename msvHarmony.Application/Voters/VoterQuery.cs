using msvHarmony.Domain.Dto;
using MediatR;

namespace msvHarmony.Application.Voters;

public record VoterQuery(
    Guid uid
    ) : IRequest<VoterDto>;

public record VoterSimpleQuery(
    Guid uid
    ) : IRequest<VoterDto>;
