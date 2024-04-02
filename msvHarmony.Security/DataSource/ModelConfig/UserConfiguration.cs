using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msvHarmony.Domain.Entities;

namespace msvHarmony.Security.DataSource.ModelConfig
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();

            builder.ToTable("Users", SecurityDbContext.SecuritySchemaName);

            //Usuario Administrador
            builder.HasData(new User
            {
                Id = "e9ae5b93-e8a3-4d8d-af2f-6f70411db22e",
                Email = "admin@localhost.com",
                NormalizedEmail = "admin@localhost.com",
                Name = "Full",
                Surname = "Administrador",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                PasswordHash = hasher.HashPassword(null, "230324Harmony"),
                EmailConfirmed = true
            });

            //Usuario regular
            builder.HasData(new User
            {
                Id = "fa0b8ea4-5ae8-49a9-9539-302c3679cdd8",
                Email = "johanscuellare@gmail.com",
                NormalizedEmail = "johanscuellare@gmail.com",
                Name = "Sebastian",
                Surname = "Cuellar",
                UserName = "SebasCuellar",
                NormalizedUserName = "SEBASCUELLAR",
                PasswordHash = hasher.HashPassword(null, "230324Harmony"),
                EmailConfirmed = true
            });
        }
    }
}
