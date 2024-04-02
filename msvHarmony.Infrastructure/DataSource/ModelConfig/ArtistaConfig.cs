using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Infrastructure.DataSource.ModelConfig
{
    public class ArtistaConfig : IEntityTypeConfiguration<Artista>
    {
        public void Configure(EntityTypeBuilder<Artista> builder)
        {
            builder.ToTable("Artista");            

            builder.Property(e => e.Nombre)
              .HasMaxLength(200)
              .IsUnicode(false);

            builder.HasData(
                new Artista
                {
                    Id = Guid.Parse("96303db8-663d-441f-b85b-f2424dc42f4c"),
                    Nombre = "Beyoncé",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Artista
                {
                    Id = Guid.Parse("b2d8a25a-01b3-454a-bb62-c829cff931b7"),
                    Nombre = "Michael Jackson",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Artista
                {
                    Id = Guid.Parse("c24fb9db-848c-4a9d-8ae0-44a97a38f0cb"),
                    Nombre = "Bob Marley",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Artista
                {
                    Id = Guid.Parse("41f40298-2bce-45b5-9cf0-6017b2b12f33"),
                    Nombre = "Shakira",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Artista
                {
                    Id = Guid.Parse("286f574b-b842-4930-86c1-b873350a0d98"),
                    Nombre = "J Balvin",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Artista
                {
                    Id = Guid.Parse("00da8580-99e6-4e16-8a0b-d8739b4f98ff"),
                    Nombre = "Bad Bunny",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Artista
                {
                    Id = Guid.Parse("740d3805-1377-4e3e-962f-16b594401624"),
                    Nombre = "Daddy Yankee",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Artista
                {
                    Id = Guid.Parse("839d6647-abb1-4b26-b096-626be91e8fa9"),
                    Nombre = "Carlos Santana",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                }
              );
        }
    }
}
