using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Infrastructure.DataSource.ModelConfig
{
    public class GeneroConfig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Genero");
            
            builder.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.HasData(
                new Genero
                {
                    Id = Guid.Parse("cdc4a9d0-9618-413c-b8ef-3c75b2f87aa4"),
                    Nombre = "Pop",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("8fed34da-dbe0-4ffb-b7e4-59b1546d446e"),
                    Nombre = "Rock",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("005ec1d9-e027-4000-bf14-007b1dd5a1a4"),
                    Nombre = "Hip-Hop/Rap",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("b0b3b676-2509-4557-93f3-91d5c134f404"),
                    Nombre = "R&B/Soul",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("b2a94699-9ff0-4e2c-a867-4e915aa86d3a"),
                    Nombre = "Jazz",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("0a2cee36-6643-43b3-b0a3-ae29aa36ebb6"),
                    Nombre = "Reggae",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("1fe91b74-2e0a-44aa-9229-8c12d985eda9"),
                    Nombre = "Country",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("8eecad94-b361-45fa-80e5-e11a424f9388"),
                    Nombre = "Electronic/Dance",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("4eb68ff4-7b9c-4618-b64b-a91f51c4bb25"),
                    Nombre = "Folk",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("baa5cc89-28d4-4ce0-8210-24b1ec453fdf"),
                    Nombre = "Blues",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("d9df4cc3-7d0d-45ce-959b-7fb34aac6d58"),
                    Nombre = "Indie",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("541dfa54-35fc-4a70-8aae-cb7b88912945"),
                    Nombre = "Metal",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("ecb3ea6f-e1db-497a-b777-b58bf7f4f77f"),
                    Nombre = "Funk",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Genero
                {
                    Id = Guid.Parse("c0fa37f3-5fb3-41d2-ba70-05fcbd352218"),
                    Nombre = "Reggaetón",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                }
              );

        }
    }
}
