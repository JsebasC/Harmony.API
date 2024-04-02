using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using msvHarmony.Domain.Entities;
using msvHarmony.Security.DataSource.ModelConfig;

namespace msvHarmony.Security.DataSource
{
    public class SecurityDbContext : IdentityDbContext<User>
    {
        public const string SecuritySchemaName = "Security";
        public SecurityDbContext(DbContextOptions<SecurityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema(SecuritySchemaName);

            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new RoleClaimConfiguration());            
            builder.ApplyConfiguration(new UserClaimConfiguration());
            builder.ApplyConfiguration(new UserLoginConfiguration());                       
            builder.ApplyConfiguration(new UserTokenConfigurations());
        }
    }
}
