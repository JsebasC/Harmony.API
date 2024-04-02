using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using msvHarmony.Domain.Models;
using msvHarmony.Domain.Models.Identity;
using msvHarmony.Domain.Ports;
using msvHarmony.Domain.Services;
using msvHarmony.Infrastructure.Adapters;
using msvHarmony.Infrastructure.Ports;

namespace msvHarmony.Infrastructure.Extensions;

public static class AutoLoadServicesSecurity
{
    public static IServiceCollection AddDomainSecurityServices(this IServiceCollection services)
    {
        // generic repository
        services.AddTransient(typeof(IRepositorySecurity<>), typeof(GenericRepositorySecurity<>));

        // unit of work
        services.AddTransient<IUnitOfWorkSecurityDbContext, UnitOfWorkSecurityDbContext>();

        // all services with domain service attribute, we can also do this "by convention",
        // naming services with suffix "Service" if decide to remove the domain service decorator
        var _services = AppDomain.CurrentDomain.GetAssemblies()
              .Where(assembly =>
              {
                  return (assembly.FullName is null) || assembly.FullName.Contains("Domain", StringComparison.InvariantCulture);
              })
              .SelectMany(s => s.GetTypes())
              .Where(p => p.CustomAttributes.Any(x => x.AttributeType == typeof(DomainSecurityServiceAttribute)));

        // Ditto, but repositories
        var _repositories = AppDomain.CurrentDomain.GetAssemblies()
            .Where(assembly =>
            {
                return (assembly.FullName is null) || assembly.FullName.Contains("Security", StringComparison.InvariantCulture);
            })
            .SelectMany(s => s.GetTypes())
            .Where(p => p.CustomAttributes.Any(x => x.AttributeType == typeof(RepositorySecurityAttribute)));

        // svc
        foreach (var service in _services)
        {
            services.AddTransient(service);
        }

        // repos
        foreach (var repo in _repositories)
        {
            Type iface = repo.GetInterfaces().Single();
            services.AddTransient(iface, repo);
        }

        return services;
    }

}
