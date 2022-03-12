using CihazTakip.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace CihazTakip.UI
{
    public static class Injector
    {
        public static IServiceCollection AddWebController(this IServiceCollection services)
        {
            services.AddInfrastructure();
            return services;
        }
    }
}
