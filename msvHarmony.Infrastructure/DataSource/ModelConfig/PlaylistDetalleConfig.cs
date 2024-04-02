using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Infrastructure.DataSource.ModelConfig
{
    public class PlaylistDetalleConfig : IEntityTypeConfiguration<PlaylistDetalle>
    {
        public void Configure(EntityTypeBuilder<PlaylistDetalle> builder)
        {
            builder.ToTable("PlaylistDetalle");

            builder.HasOne(d => d.Cancion).WithMany(p => p.PlaylistDetalles)
                .HasForeignKey(d => d.CancionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlaylistDetalle_Cancion");

            builder.HasOne(d => d.Playlist).WithMany(p => p.PlaylistDetalles)
                .HasForeignKey(d => d.PlaylistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlaylistDetalle_Playlist");
        }
    }
}
