using CloudResumeChallengeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudResumeChallengeAPI.Data
{
    public abstract class IDataContext : DbContext
    {
        public IDataContext()
        {
        }

        public IDataContext(DbContextOptions<IDataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("API");
                optionsBuilder.UseSqlite(connectionString);
            }
        }

        public DbSet<PageVisits> PageVisits { get; set; }
    }
}
