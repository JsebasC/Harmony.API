using msvHarmony.Domain.Dto;

namespace msvHarmony.Domain.Ports
{
    public interface IVoterSimpleQueryRepository
    {
        Task<VoterDto> Single(Guid id);
    }
}

