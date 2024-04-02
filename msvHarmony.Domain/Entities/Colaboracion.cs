using msvHarmony.Domain.Entities.Base;

namespace msvHarmony.Domain.Entities;

public partial class Colaboracion : DomainEntity
{    

    public Guid CancionId { get; set; }

    public Guid ArtistaId { get; set; }

    public virtual Cancion Cancion { get; set; } = null!;
}
