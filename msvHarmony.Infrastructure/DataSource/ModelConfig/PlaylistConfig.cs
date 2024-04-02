using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Infrastructure.DataSource.ModelConfig
{
    public class PlaylistConfig : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.ToTable("Playlist");

            builder.Property(e => e.Nombre).HasMaxLength(200);
            builder.Property(e => e.UsuarioId).HasMaxLength(450);
        }
    }
}
