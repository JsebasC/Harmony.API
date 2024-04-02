using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace msvHarmony.Security.DataSource.ModelConfig
{
    public class UserTokenConfigurations : IEntityTypeConfiguration<IdentityUserToken<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserToken<string>> builder)
        {
            builder.ToTable("UserTokens", SecurityDbContext.SecuritySchemaName);
        }
    }
}
