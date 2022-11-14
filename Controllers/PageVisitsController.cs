using CloudResumeChallengeAPI.Repositories;

namespace CloudResumeChallengeAPI.Controllers
{
    public class PageVisitsController
    {
        private readonly PageVisitsRepository _repository;
        public PageVisitsController(PageVisitsRepository repository)
        {
            _repository = repository;
        }

        public void GetPageVisits()
        {

        }

        public void CreatePageVisit()
        {

        }
    }
}
