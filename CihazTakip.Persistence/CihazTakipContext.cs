using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace CihazTakip.Persistence
{
    public class CihazTakipContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public CihazTakipContext(DbContextOptions<CihazTakipContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
