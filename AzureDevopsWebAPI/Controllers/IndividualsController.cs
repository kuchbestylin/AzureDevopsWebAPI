using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AzureDevopsWebAPI.Data;
using AzureDevopsWebAPI.Models;

namespace AzureDevopsWebAPI.Controllers
{
    [Route("api/AzureDevops")]
    [ApiController]
    public class IndividualsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public IndividualsController(ApplicationDBContext context)
        {
            _context = context;
        }

        //// GET: Individuals
        //public async Task<IActionResult> GetIndividuals()
        //{
        //      //return _context.Individuals != null ? 
        //      //            View(await _context.Individuals.ToListAsync()) :
        //      //            Problem("Entity set 'ApplicationDBContext.Individuals'  is null.");
        //}

        //// GET: Individuals/GetIndividual/5
        //public async Task<IActionResult> GetIndividual(int? id)
        //{
        //    if (id == null || _context.Individuals == null)
        //    {
        //        return NotFound();
        //    }

        //    var individual = await _context.Individuals
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (individual == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(individual);
        //}

        //// GET: Individuals/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Individuals/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,ProjectName,StartDateTime,EndDateTime")] Individual individual)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(individual);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(GetIndividuals));
        //    }
        //    return View(individual);
        //}

        //// GET: Individuals/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Individuals == null)
        //    {
        //        return NotFound();
        //    }

        //    var individual = await _context.Individuals.FindAsync(id);
        //    if (individual == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(individual);
        //}

        //// POST: Individuals/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,ProjectName,StartDateTime,EndDateTime")] Individual individual)
        //{
        //    if (id != individual.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(individual);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!IndividualExists(individual.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(GetIndividuals));
        //    }
        //    return View(individual);
        //}

        //// GET: Individuals/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Individuals == null)
        //    {
        //        return NotFound();
        //    }

        //    var individual = await _context.Individuals
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (individual == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(individual);
        //}

        //// POST: Individuals/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Individuals == null)
        //    {
        //        return Problem("Entity set 'ApplicationDBContext.Individuals'  is null.");
        //    }
        //    var individual = await _context.Individuals.FindAsync(id);
        //    if (individual != null)
        //    {
        //        _context.Individuals.Remove(individual);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(GetIndividuals));
        //}

        //private bool IndividualExists(int id)
        //{
        //  return (_context.Individuals?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
