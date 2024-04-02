using msvHarmony.Domain.Entities.Base;

namespace msvHarmony.Domain.Entities;

public partial class Favorito : DomainEntity
{    
    public string UsuarioId { get; set; } = null!;

    public Guid CancionId { get; set; }

    public virtual Cancion Cancion { get; set; } = null!;
}
