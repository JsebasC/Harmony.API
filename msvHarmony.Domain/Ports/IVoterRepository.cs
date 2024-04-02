using msvHarmony.Domain.Entities;

namespace msvHarmony.Domain.Ports
{
    public interface IVoterRepository
    {
        Task<Voter> SaveVoter(Voter v);     
        Task<Voter> SingleVoter(Guid uid);   
        
    }

   
}

