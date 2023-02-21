using AzureDevopsWebAPI.Data;
using AzureDevopsWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureDevopsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualByEmailController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public IndividualByEmailController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Individual>> getIndividualByEmail(string email)
        {
            if (email == null)
                return BadRequest(string.Empty);
            var individual = _context.Individuals.FirstOrDefault(x => x.Email == email);
            if (individual == null)
                return NotFound();

            return Ok(individual);
        }
    }
}
