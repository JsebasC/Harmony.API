using msvHarmony.Domain.Dto;
using MediatR;


namespace msvHarmony.Application.Voters;

public record VoterRegisterCommand(
    string Nid, string Origin, DateTime Dob
    ) : IRequest<VoterDto>;

