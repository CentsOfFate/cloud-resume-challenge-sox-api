using Microsoft.EntityFrameworkCore;
using CloudResumeChallengeAPI.Models;

namespace CloudResumeChallengeAPI.Data
{
    public class DataContext : IDataContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<IDataContext> options)
            : base(options)
        {
        }
    }
}
