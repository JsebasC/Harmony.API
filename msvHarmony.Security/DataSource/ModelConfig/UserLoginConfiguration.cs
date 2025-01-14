﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace msvHarmony.Security.DataSource.ModelConfig
{
    public class UserLoginConfiguration : IEntityTypeConfiguration<IdentityUserLogin<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> builder)
        {
            builder.ToTable("UserLogins", SecurityDbContext.SecuritySchemaName);
        }
    }
}
