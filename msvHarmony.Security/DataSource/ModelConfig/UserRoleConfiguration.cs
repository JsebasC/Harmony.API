using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace msvHarmony.Security.DataSource.ModelConfig
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        //Vinculo entre rol y usuario
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.ToTable("UserRoles", SecurityDbContext.SecuritySchemaName);
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "29b68c9a-af80-4582-b574-8d0523488143",
                    UserId = "e9ae5b93-e8a3-4d8d-af2f-6f70411db22e"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "27b93ae3-2500-4bc1-b935-5da976327813",
                    UserId = "fa0b8ea4-5ae8-49a9-9539-302c3679cdd8"
                }
            );
        }
    }
}
