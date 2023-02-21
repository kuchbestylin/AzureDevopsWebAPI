using AzureDevopsWebAPI.Data;
using AzureDevopsWebAPI.Models;
using AzureDevopsWebAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureDevopsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangeLogsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ChangeLogsController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}", Name = "getChangeLogsById")]
        public ActionResult<IEnumerable<ChangeLog>> GetChangeLogsById(string email)
        {
            var individual = _context.Individuals.FirstOrDefault(i => i.Email.ToLower() == email.ToLower());
            if (individual == null)
                return NotFound("Indivual not registered with the system");

            var logs = _context.ChangeLogs.Include(l => l.Project).Include(o => o.ItemType).Where(log => log.IndividualId == individual.Id);

            return Ok(logs);
        }

        [HttpPost(Name = "PostChangeLog")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ChangeLogDto>> PostChangeLog(ChangeLogDto changeLog)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid arguments supplied");

            var individual = _context.Individuals.FirstOrDefault(i => i.Id == changeLog.IndividualId);

            if (individual == null)
                return BadRequest("User does not exist");

            var log = new ChangeLog
            {
                ProjectId = changeLog.ProjectId,
                StartDateTime = DateTime.UtcNow,
                Summary = changeLog.Summary,
                IndividualId = changeLog.IndividualId,
                ItemTypeId = changeLog.ItemTypeId
            };

            await _context.ChangeLogs.AddAsync(log);
            await _context.SaveChangesAsync();

            return Ok(log);
        }
    }
}
