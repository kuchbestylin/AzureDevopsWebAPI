using AzureDevopsWebAPI.Data;
using AzureDevopsWebAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDevopsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public LoginController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult login(LoginDto loginDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var individual = _context.Individuals.FirstOrDefault(i => i.Email.ToLower() == loginDto.Email.ToLower() && i.Password == loginDto.Password);

            if (individual == null)
                return NotFound();

            return Ok();
        }
    }
}
