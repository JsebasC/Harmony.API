using msvHarmony.Domain.Entities.Base;

namespace msvHarmony.Domain.Entities;

public partial class Album : DomainEntity
{    

    public string Titulo { get; set; } = null!;

    public int Anio { get; set; }

    public string? Portada { get; set; }

    public Guid ArtistaId { get; set; }

    public Guid GeneroId { get; set; }

    public Guid DiscograficaId { get; set; }

    public virtual Artista Artista { get; set; } = null!;

    public virtual ICollection<Cancion> Cancions { get; } = new List<Cancion>();

    public virtual Discografica Discografica { get; set; } = null!;

    public virtual Genero Genero { get; set; } = null!;
}
