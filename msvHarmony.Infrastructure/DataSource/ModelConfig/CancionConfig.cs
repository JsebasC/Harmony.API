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
                // Canciones del álbum "Thriller" de Michael Jackson
                new Cancion
                {
                    Id = Guid.Parse("32b45778-764a-4ae0-9a44-5555d189d6a9"),
                    Nombre = "Wanna Be Startin' Somethin'",
                    Duracion = 283,
                    Portada = "Wanna.jpg",
                    AlbumId = Guid.Parse("dddf3f3e-c737-4d93-81bf-2a15354ceee7"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Cancion
                {
                    Id = Guid.Parse("d2f3c9a1-46e5-40d6-b782-674ba61334c8"),
                    Nombre = "Thriller",
                    Duracion = 357,
                    Portada = "Thriller-Cancion.jpg",
                    AlbumId = Guid.Parse("dddf3f3e-c737-4d93-81bf-2a15354ceee7"),
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
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Cancion
                {
                    Id = Guid.Parse("34645ff8-7bd8-42d6-9749-1beae05ff7ad"),
                    Nombre = "Hoy Cobré",
                    Duracion = 219,
                    Portada = "HoyCobre.jpg",
                    AlbumId = Guid.Parse("a9cbd226-1b7b-4efe-b5d1-b2951bf16d39"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                // Canciones del álbum "Oasis" de Bad Bunny y J Balvin
                new Cancion
                {
                    Id = Guid.Parse("9cf403ae-6c10-47aa-95ca-5dc3403ec2da"),
                    Nombre = "Qué Pretendes",
                    Duracion = 246,
                    Portada = "Pretendes.jpg",
                    AlbumId = Guid.Parse("09f84863-c6bd-4d04-a076-a145847496c8"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Cancion
                {
                    Id = Guid.Parse("59bcaa11-7849-41e1-8e50-beb241e1d612"),
                    Nombre = "La Canción",
                    Duracion = 263,
                    Portada = "LaCancion.jpg",
                    AlbumId = Guid.Parse("09f84863-c6bd-4d04-a076-a145847496c8"),
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
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Cancion
                {
                    Id = Guid.Parse("d7584f4f-5b7e-4102-886c-20a59cd22752"),
                    Nombre = "Caro",
                    Duracion = 214,
                    Portada = "Caro.jpg",
                    AlbumId = Guid.Parse("36f0c39c-006c-4ba9-b9f1-93a0cb9c2695"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                }
            );
        }
    }
}
