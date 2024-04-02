using msvHarmony.Domain.Entities.Base;

namespace msvHarmony.Domain.Entities;

public partial class Cancion : DomainEntity
{    

    public string Nombre { get; set; } = null!;

    public int Duracion { get; set; }

    public string? Portada { get; set; }

    public Guid AlbumId { get; set; }

    public virtual Album Album { get; set; } = null!;

    public virtual ICollection<Colaboracion> Colaboracions { get; } = new List<Colaboracion>();

    public virtual ICollection<Favorito> Favoritos { get; } = new List<Favorito>();

    public virtual ICollection<PlaylistDetalle> PlaylistDetalles { get; } = new List<PlaylistDetalle>();
}
