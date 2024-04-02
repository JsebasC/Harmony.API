using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace msvHarmony.Security.DataSource.ModelConfig
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        //Semilla roles
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.ToTable("Roles", SecurityDbContext.SecuritySchemaName);
            builder.HasData(
                new IdentityRole
                {
                    Id = "29b68c9a-af80-4582-b574-8d0523488143",
                    Name = "Admin",
                    NormalizedName = "Admin"
                },
                new IdentityRole
                {
                    Id = "27b93ae3-2500-4bc1-b935-5da976327813",
                    Name = "Usuario",
                    NormalizedName = "Usuario"
                }
            );
        }
    }
}
