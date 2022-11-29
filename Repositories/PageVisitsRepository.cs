using CloudResumeChallengeAPI.Data;
using CloudResumeChallengeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudResumeChallengeAPI.Repositories
{
    public class PageVisitsRepository : IPageVisitsRepository
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

        public async Task CreatePageVisit()
        {
            PageVisits pageVisits = new PageVisits()
            {
                Id = 0,
                VisitedDate = DateTime.Now
            };

            _context.PageVisits.Add(pageVisits);
            await _context.SaveChangesAsync();
        }
    }
}
