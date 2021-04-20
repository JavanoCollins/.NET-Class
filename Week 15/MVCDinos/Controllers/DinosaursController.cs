using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCDinos.Data;
using MVCDinos.Models;

namespace MVCDinos.Controllers
{
    public class DinosaursController : Controller
    {
        private readonly DinosaurContext _context;

        public DinosaursController(DinosaurContext context)
        {
            _context = context;
        }

        // GET: Dinosaurs
        public async Task<IActionResult> Index(string SearchString, string DinoNames)
        {
            IQueryable<string> nameQuery = from b in _context.Dinosaurs orderby b.DinosaurName select b.DinosaurName;

            var dino = from b in _context.Dinosaurs select b;

            if(!String.IsNullOrEmpty(SearchString))
            {
                dino = dino.Where(b => b.DinosaurName.Contains(SearchString));
            }

            if(!string.IsNullOrEmpty(DinoNames))
            {
                dino = dino.Where(k => k.DinosaurName == DinoNames);
            }

            var dinoNameVM = new DinoViewModel
            {
                Names = new SelectList(await nameQuery.Distinct().ToListAsync()),
                Dinosaurs = await dino.ToListAsync()
            };

            return View(dinoNameVM);
        }

        // GET: Dinosaurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dinosaur = await _context.Dinosaurs
                .FirstOrDefaultAsync(m => m.DinosaurID == id);
            if (dinosaur == null)
            {
                return NotFound();
            }

            return View(dinosaur);
        }

        // GET: Dinosaurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dinosaurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DinosaurID,DinosaurName,Pronounced,BriefDesc,NameMeans,LengthFt,WeightLbs,LivedYearsAgo,ClassID,PeriodID")] Dinosaur dinosaur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dinosaur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dinosaur);
        }

        // GET: Dinosaurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dinosaur = await _context.Dinosaurs.FindAsync(id);
            if (dinosaur == null)
            {
                return NotFound();
            }
            return View(dinosaur);
        }

        // POST: Dinosaurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DinosaurID,DinosaurName,Pronounced,BriefDesc,NameMeans,LengthFt,WeightLbs,LivedYearsAgo,ClassID,PeriodID")] Dinosaur dinosaur)
        {
            if (id != dinosaur.DinosaurID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dinosaur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DinosaurExists(dinosaur.DinosaurID))
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
            return View(dinosaur);
        }

        // GET: Dinosaurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dinosaur = await _context.Dinosaurs
                .FirstOrDefaultAsync(m => m.DinosaurID == id);
            if (dinosaur == null)
            {
                return NotFound();
            }

            return View(dinosaur);
        }

        // POST: Dinosaurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dinosaur = await _context.Dinosaurs.FindAsync(id);
            _context.Dinosaurs.Remove(dinosaur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DinosaurExists(int id)
        {
            return _context.Dinosaurs.Any(e => e.DinosaurID == id);
        }
    }
}
