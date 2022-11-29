using CloudResumeChallengeAPI.Models;

namespace CloudResumeChallengeAPI.Repositories
{
    public interface IPageVisitsRepository
    {
        Task CreatePageVisit();
        Task<IEnumerable<PageVisits>> GetPageVisits();
    }
}