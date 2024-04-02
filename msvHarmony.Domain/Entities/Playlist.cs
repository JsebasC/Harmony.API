using msvHarmony.Domain.Entities.Base;

namespace msvHarmony.Domain.Entities;

public partial class Playlist : DomainEntity
{    

    public string Nombre { get; set; } = null!;

    public string UsuarioId { get; set; } = null!;

    public virtual ICollection<PlaylistDetalle> PlaylistDetalles { get; } = new List<PlaylistDetalle>();
}
