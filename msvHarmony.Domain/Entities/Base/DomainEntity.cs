namespace msvHarmony.Domain.Entities.Base;

public class DomainEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime LastModifiedOn { get; set; }
}


