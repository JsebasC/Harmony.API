using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Infrastructure.DataSource.ModelConfig
{
    public class DiscograficaConfig : IEntityTypeConfiguration<Discografica>
    {
        public void Configure(EntityTypeBuilder<Discografica> builder)
        {
            builder.ToTable("Discografica");            

            builder.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.HasData(
                new Discografica
                {
                    Id = Guid.Parse("7e49603a-44e5-48d3-990c-691008b0e88a"),
                    Nombre = "Sony Music Entertainment",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Discografica
                {
                    Id = Guid.Parse("71f1d39b-5fbd-42d7-b4df-a904880b904d"),
                    Nombre = "Universal Music Group",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Discografica
                {
                    Id = Guid.Parse("34a47160-6312-4f1f-a220-4608acb7daac"),
                    Nombre = "Warner Music Group",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                },
                new Discografica
                {
                    Id = Guid.Parse("315721f0-9942-4ca2-a7cb-af423dac1d20"),
                    Nombre = "EMI Music",
                    CreatedOn = DateTime.Now,
                    LastModifiedOn = DateTime.Now
                }
            );
        }
    }
}
