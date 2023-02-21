using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AzureDevopsWebAPI.Data;
using AzureDevopsWebAPI.Models;
using AzureDevopsWebAPI.Models.Dto;

namespace AzureDevopsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public IndividualsController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "Individuals")]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Individual>> getIndividuals()
        {
            return Ok(_context.Individuals.ToList());
        }

        [HttpPost]
        public ActionResult<Individual> postIndividuals(IndividualDto individual)
        {
            if (individual.Password == null)
                individual.Password = "0000";

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var exists = _context.Individuals.FirstOrDefault(i => i.Email.ToLower() == individual.Email.ToLower());

            var individual2 = new Individual
            {
                Id = 0,
                Email = individual.Email,
                AccessLevelId = 7,
                Password = individual.Password 
            };

            var inserted = _context.Individuals.Add(individual2);
            _context.SaveChanges();

            return Ok(inserted.Entity);
        }
    }
}
