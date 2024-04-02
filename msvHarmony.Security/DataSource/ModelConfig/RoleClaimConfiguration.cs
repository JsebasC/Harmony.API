using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace msvHarmony.Security.DataSource.ModelConfig
{

    public class RoleClaimConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityRoleClaim<string>> builder)
        {
            builder.ToTable("RoleClaims", SecurityDbContext.SecuritySchemaName);
        }
    }
}
