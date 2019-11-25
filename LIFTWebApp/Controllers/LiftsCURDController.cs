using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LIFTWebApp.Models;

namespace LIFTWebApp.Controllers
{
    public class LiftsCURDController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LiftsCURDController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LiftsCURD
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lifts.ToListAsync());
        }

        // GET: LiftsCURD/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lift = await _context.Lifts
                .FirstOrDefaultAsync(m => m.LiftID == id);
            if (lift == null)
            {
                return NotFound();
            }

            return View(lift);
        }

        // GET: LiftsCURD/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LiftsCURD/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LiftID,UserID,DateTimePerformed,ExercisePerfromed,Weight,Reps")] Lift lift)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lift);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lift);
        }

        // GET: LiftsCURD/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lift = await _context.Lifts.FindAsync(id);
            if (lift == null)
            {
                return NotFound();
            }
            return View(lift);
        }

        // POST: LiftsCURD/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LiftID,UserID,DateTimePerformed,ExercisePerfromed,Weight,Reps")] Lift lift)
        {
            if (id != lift.LiftID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lift);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LiftExists(lift.LiftID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lift);
        }

        // GET: LiftsCURD/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lift = await _context.Lifts
                .FirstOrDefaultAsync(m => m.LiftID == id);
            if (lift == null)
            {
                return NotFound();
            }

            return View(lift);
        }

        // POST: LiftsCURD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lift = await _context.Lifts.FindAsync(id);
            _context.Lifts.Remove(lift);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LiftExists(int id)
        {
            return _context.Lifts.Any(e => e.LiftID == id);
        }
    }
}
