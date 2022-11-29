using CloudResumeChallengeAPI.Models;
using CloudResumeChallengeAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CloudResumeChallengeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public class PageVisitsController : ControllerBase
    {
        private readonly IPageVisitsRepository _repository;
        public PageVisitsController(IPageVisitsRepository repository)
        {
            _repository = repository;
        }

        // GET: api/PageVisits
        /// <summary>
        /// Get All PageVisits
        /// </summary>
        /// <returns>List of PageVisits</returns>
        /// <response code="200">Returns Page Visits</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<PageVisits>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPageVisits()
        {
            return Ok(await _repository.GetPageVisits());
        }

        // POST: api/PageVisits
        /// <summary>
        /// Create a PageVisit
        /// </summary>
        /// <response code="200">Returns Void</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreatePageVisit()
        {
            await _repository.CreatePageVisit();
            return Ok();
        }
    }
}
