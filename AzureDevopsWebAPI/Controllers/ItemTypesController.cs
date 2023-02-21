using AzureDevopsWebAPI.Data;
using AzureDevopsWebAPI.Models;
using AzureDevopsWebAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureDevopsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemTypesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ItemTypesController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "getItemTypes")]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<ItemType>> getItemTypes()
        {
            return Ok(_context.ItemTypes.ToList());
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public ActionResult<IEnumerable<ItemType>> postItemTypes(ItemType itemType)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model Invalid");

            _context.ItemTypes.Add(itemType);
            _context.SaveChanges();
            return Ok(itemType);
        }
    }
}
