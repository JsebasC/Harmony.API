using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Infrastructure.DataSource.ModelConfig
{
    public class FavoritoConfig : IEntityTypeConfiguration<Favorito>
    {
        public void Configure(EntityTypeBuilder<Favorito> builder)
        {
            builder.ToTable("Favorito");            

            builder.Property(e => e.UsuarioId).HasMaxLength(450);

            builder.HasOne(d => d.Cancion).WithMany(p => p.Favoritos)
                .HasForeignKey(d => d.CancionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Favorito_Cancion");
        }
    }
}
