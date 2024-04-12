using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Infrastructure.DataSource.ModelConfig
{
    public class AlbumConfig : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("Album");

            builder.Property(e => e.Titulo)
                .HasMaxLength(200)
                .IsUnicode(false);
            builder.Property(e => e.Portada).IsUnicode(false);
            builder.Property(e => e.Anio).IsUnicode(false);

            builder.HasOne(d => d.Artista).WithMany(p => p.Albums)
                .HasForeignKey(d => d.ArtistaId)
                .HasConstraintName("FK_Album_Artista");

            builder.HasOne(d => d.Discografica).WithMany(p => p.Albums)
                .HasForeignKey(d => d.DiscograficaId)
                .HasConstraintName("FK_Album_Discografica");

            builder.HasOne(d => d.Genero).WithMany(p => p.Albums)
                .HasForeignKey(d => d.GeneroId)
                .HasConstraintName("FK_Album_Genero");

            builder.HasData(
                new Album
                {
                    Id = Guid.Parse("dddf3f3e-c737-4d93-81bf-2a15354ceee7"),
                    Titulo = "Thriller",
                    Anio = 1982,
                    Portada = "Thriller.jpg",
                    GeneroId = Guid.Parse("8fed34da-dbe0-4ffb-b7e4-59b1546d446e"),
                    ArtistaId = Guid.Parse("b2d8a25a-01b3-454a-bb62-c829cff931b7"),
                    DiscograficaId = Guid.Parse("7e49603a-44e5-48d3-990c-691008b0e88a"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Album
                {
                    Id = Guid.Parse("2d45f863-ce4d-4671-a75f-78e978ccb7ca"),
                    Titulo = "Exodus",
                    Anio = 1977,
                    Portada = "Exodus.jpg",
                    GeneroId = Guid.Parse("0a2cee36-6643-43b3-b0a3-ae29aa36ebb6"),
                    ArtistaId = Guid.Parse("c24fb9db-848c-4a9d-8ae0-44a97a38f0cb"),
                    DiscograficaId = Guid.Parse("7e49603a-44e5-48d3-990c-691008b0e88a"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Album
                {
                    Id = Guid.Parse("a9cbd226-1b7b-4efe-b5d1-b2951bf16d39"),
                    Titulo = "El Último Tour del Mundo",
                    Anio = 2020,
                    Portada = "UltimoTour.jpg",
                    GeneroId = Guid.Parse("c0fa37f3-5fb3-41d2-ba70-05fcbd352218"),
                    ArtistaId = Guid.Parse("00da8580-99e6-4e16-8a0b-d8739b4f98ff"),
                    DiscograficaId = Guid.Parse("71f1d39b-5fbd-42d7-b4df-a904880b904d"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Album
                {
                    Id = Guid.Parse("09f84863-c6bd-4d04-a076-a145847496c8"),
                    Titulo = "Oasis",
                    Anio = 2019,
                    Portada = "Oasis.jpg",
                    GeneroId = Guid.Parse("c0fa37f3-5fb3-41d2-ba70-05fcbd352218"),
                    ArtistaId = Guid.Parse("286f574b-b842-4930-86c1-b873350a0d98"),
                    DiscograficaId = Guid.Parse("315721f0-9942-4ca2-a7cb-af423dac1d20"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Album
                {
                    Id = Guid.Parse("36f0c39c-006c-4ba9-b9f1-93a0cb9c2695"),
                    Titulo = "X 100pre",
                    Anio = 2018,
                    Portada = "PorSiempre.jpg",
                    GeneroId = Guid.Parse("c0fa37f3-5fb3-41d2-ba70-05fcbd352218"),
                    ArtistaId = Guid.Parse("00da8580-99e6-4e16-8a0b-d8739b4f98ff"),
                    DiscograficaId = Guid.Parse("34a47160-6312-4f1f-a220-4608acb7daac"),
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                }
            );
        }
    }
}
