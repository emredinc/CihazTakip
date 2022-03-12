using CihazTakip.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CihazTakip.Infrastructure
{
    public static class Injector
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddRepository();
            return services;
        }
    }
}
