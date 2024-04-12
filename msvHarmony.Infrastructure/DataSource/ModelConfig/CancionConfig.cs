using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Infrastructure.DataSource.ModelConfig
{
    public class CancionConfig : IEntityTypeConfiguration<Cancion>
    {
        public void Configure(EntityTypeBuilder<Cancion> builder)
        {
            builder.ToTable("Cancion");            

            builder.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            builder.Property(e => e.Portada).IsUnicode(false);            

            builder.HasOne(d => d.Album).WithMany(p => p.Cancions)
                .HasForeignKey(d => d.AlbumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cancion_Album");

            builder.HasData(               
                new Cancion
                {
                    Id = Guid.Parse("d2f3c9a1-46e5-40d6-b782-674ba61334c8"),
                    Nombre = "Thriller",
                    Duracion = 357,
                    Portada = "Thriller-Cancion.jpg",
                    AlbumId = Guid.Parse("dddf3f3e-c737-4d93-81bf-2a15354ceee7"),
                    Source = "thriller.mp3",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                // Canciones del álbum "El Último Tour del Mundo" de Bad Bunny
                new Cancion
                {
                    Id = Guid.Parse("dbf159ea-55f1-44f5-a98e-36d45b62bc28"),
                    Nombre = "Te Mudaste",
                    Duracion = 210,
                    Portada = "TeMudaste.jpg",
                    AlbumId = Guid.Parse("a9cbd226-1b7b-4efe-b5d1-b2951bf16d39"),
                    Source = "te-mudaste.mp3",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },            
                // Canciones del álbum "Oasis" de Bad Bunny y J Balvin              
                new Cancion
                {
                    Id = Guid.Parse("59bcaa11-7849-41e1-8e50-beb241e1d612"),
                    Nombre = "La Canción",
                    Duracion = 263,
                    Portada = "LaCancion.jpg",
                    AlbumId = Guid.Parse("09f84863-c6bd-4d04-a076-a145847496c8"),
                    Source = "la-cancion.mp3",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                // Canciones del álbum "X 100pre" de Bad Bunny
                new Cancion
                {
                    Id = Guid.Parse("090e58d6-0f99-471d-a614-9401882fadcb"),
                    Nombre = "Ni Bien Ni Mal",
                    Duracion = 207,
                    Portada = "NiBienMal.jpg",
                    AlbumId = Guid.Parse("36f0c39c-006c-4ba9-b9f1-93a0cb9c2695"),
                    Source = "niBienMal.mp3",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                // Canciones del álbum exodus
                new Cancion
                {
                    Id = Guid.Parse("30eb8630-4ab5-4a04-a9f8-ed6eeb622da7"),
                    Nombre = "Natural Mystic",
                    Duracion = 207,
                    Portada = "Natural-Mystic.jpg",
                    AlbumId = Guid.Parse("2d45f863-ce4d-4671-a75f-78e978ccb7ca"),
                    Source = "natural-mystic.mp3",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                }
            );
        }
    }
}
