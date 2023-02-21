using AzureDevopsWebAPI.Data;
using AzureDevopsWebAPI.Models;
using AzureDevopsWebAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDevopsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ProjectsController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Project>> getProjects(string email)
        {
            var individual = _context.Individuals.FirstOrDefault(i => i.Email == email);

            if (individual == null)
                return NotFound("User not registered with the system");

            var projects = _context.Projects.Where(project => project.AccessLevelId >= individual.AccessLevelId);
            var resultSet = new List<ProjectDto>();

            foreach (var project in projects)
            {
                ProjectDto dto = new ProjectDto
                {
                    Id = project.Id,
                    Name = project.Name
                };
                resultSet.Add(dto);
            }

            return Ok(resultSet);
        }

        [HttpPost("{id:int}", Name = "addProject")]
        public ActionResult<Project> addProject(string email, ProjectDto projectDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var individual = _context.Individuals.FirstOrDefault(i => i.Email == email);
            var project = _context.Projects.FirstOrDefault(p => p.Name == projectDto.Name);

            if (project != null)
                return BadRequest("Project already exits.");

            if (individual == null)
                return BadRequest("Invalid User");

            var task = new Project
            {
                Name = projectDto.Name,
                AccessLevelId = (int)individual.AccessLevelId
            };

            _context.Projects.Add(task);
            _context.SaveChanges();

            return Ok(task);
        }
    }
}
