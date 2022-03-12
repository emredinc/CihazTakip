using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CihazTakip.Persistence
{
    public static class Injector
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<CihazTakipContext>();
            services.AddTransient<DbContext, CihazTakipContext>();
            var daoContext = services.BuildServiceProvider().GetService<CihazTakipContext>();
            daoContext.Database.Migrate();
            return services;
        }
    }
}
