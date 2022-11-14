using CloudResumeChallengeAPI.Data;
using CloudResumeChallengeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudResumeChallengeAPI.Repositories
{
    public class PageVisitsRepository
    {
        private readonly DataContext _context;
        public PageVisitsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PageVisits>> GetPageVisits()
        {
            return await _context.PageVisits.ToListAsync();
        }

        public void CreatePageVisit()
        {
            PageVisits pageVisits = new PageVisits()
            {
                Id = 0,
                VisitedDate = DateTime.Now
            };

            _context.PageVisits.Add(pageVisits);
            _context.SaveChangesAsync();
        }
    }
}
