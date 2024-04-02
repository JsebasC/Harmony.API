using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Entities.Base;

namespace msvHarmony.Infrastructure.DataSource;

public partial class HarmonyContext : DbContext
{
    private readonly IConfiguration _config;

    public HarmonyContext(DbContextOptions<HarmonyContext> options, IConfiguration config) : base(options)
    {
        _config = config;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HarmonyContext).Assembly);        
        modelBuilder.Entity<Artista>();
        modelBuilder.Entity<Genero>();
        modelBuilder.Entity<Discografica>();
        modelBuilder.Entity<Album>();        
        modelBuilder.Entity<Cancion>();
        modelBuilder.Entity<Colaboracion>();        
        modelBuilder.Entity<Favorito>();        
        modelBuilder.Entity<Playlist>();
        modelBuilder.Entity<PlaylistDetalle>();

        // ghost properties for audit
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var t = entityType.ClrType;
            if (typeof(DomainEntity).IsAssignableFrom(t))
            {
                modelBuilder.Entity(entityType.Name).Property<DateTime>("CreatedOn");
                modelBuilder.Entity(entityType.Name).Property<DateTime>("LastModifiedOn");
            }
        }

        base.OnModelCreating(modelBuilder);

    }
}
