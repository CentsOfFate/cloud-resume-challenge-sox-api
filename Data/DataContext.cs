using Microsoft.EntityFrameworkCore;
using CloudResumeChallengeAPI.Models;

namespace CloudResumeChallengeAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<PageVisits> PageVisits { get; set; }
    }
}
