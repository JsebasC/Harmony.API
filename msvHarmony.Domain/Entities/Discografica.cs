using msvHarmony.Domain.Entities.Base;

namespace msvHarmony.Domain.Entities;

public partial class Discografica: DomainEntity
{    

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Album> Albums { get; } = new List<Album>();
}
