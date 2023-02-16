using AzureDevopsWebAPI.Data;
using AzureDevopsWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDevopsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ChangesController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Project>> getProjects()
        {
            return _context.Projects.ToArray();
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ChangeLog>> PostChangeLog(int id, ChangeLog changeLog)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var individual = _context.Individuals.FirstOrDefault(i => i.Id == id);

            if (individual == null)
                return BadRequest("User does not exist");

            await _context.ChangeLogs.AddAsync(changeLog);
            await _context.SaveChangesAsync();

            return Ok(changeLog);
        }
    }
}
