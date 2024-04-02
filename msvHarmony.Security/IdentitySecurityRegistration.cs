using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using msvHarmony.Domain.Entities;
using msvHarmony.Domain.Models.Identity;
using msvHarmony.Domain.Ports;
using msvHarmony.Domain.Services;
using msvHarmony.Security.DataSource;
using System.Text;

namespace msvHarmony.Security
{
    public static class IdentitySecurityRegistration
    {
        public static IServiceCollection ConfigureSecurityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            services.AddDbContext<SecurityDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("security"),
                b => b.MigrationsAssembly(typeof(SecurityDbContext).Assembly.FullName)));

            services.AddIdentity<User, IdentityRole>(options =>options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<SecurityDbContext>().AddDefaultTokenProviders();

            services.AddTransient<IAuthService, AuthService>();

            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;                
            }).AddJwtBearer(options =>
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidIssuer = configuration["JwtSettings:Issuer"],
                    ValidAudience = configuration["JwtSettings:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:key"]))
                }
            );

            return services;
        }

    }
}
