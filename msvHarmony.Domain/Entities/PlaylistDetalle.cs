using msvHarmony.Domain.Entities.Base;

namespace msvHarmony.Domain.Entities;

public partial class PlaylistDetalle : DomainEntity
{    

    public Guid PlaylistId { get; set; }

    public Guid CancionId { get; set; }

    public virtual Cancion Cancion { get; set; } = null!;

    public virtual Playlist Playlist { get; set; } = null!;
}
