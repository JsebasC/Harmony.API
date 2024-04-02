using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace msvHarmony.Security.DataSource.ModelConfig
{
    public class UserClaimConfiguration : IEntityTypeConfiguration<IdentityUserClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
        {
            builder.ToTable("UserClaims", SecurityDbContext.SecuritySchemaName);
        }
    }
}
