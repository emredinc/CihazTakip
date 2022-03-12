using CihazTakip.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace CihazTakip.Repository
{
    public static class Injector
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddPersistence();
            //örnek satır
            return services;
        }
    }
}
