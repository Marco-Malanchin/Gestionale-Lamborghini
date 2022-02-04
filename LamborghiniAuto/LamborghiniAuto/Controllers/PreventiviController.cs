using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LamborghiniAuto.Data;
using LamborghiniAuto.Models;
using Microsoft.AspNetCore.Authorization;

namespace LamborghiniAuto.Controllers
{
    public class PreventiviController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PreventiviController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Preventivi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Preventivo.ToListAsync());
        }

        // GET: Preventivi/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preventivo = await _context.Preventivo
                .FirstOrDefaultAsync(m => m.id == id);
            if (preventivo == null)
            {
                return NotFound();
            }

            return View(preventivo);
        }

        [Authorize]
        // GET: Preventivi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Preventivi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nomeCl,cognomeCl,numeroCl")] Preventivo preventivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(preventivo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        // GET: Preventivi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preventivo = await _context.Preventivo.FindAsync(id);
            if (preventivo == null)
            {
                return NotFound();
            }
            return View(preventivo);
        }

        // POST: Preventivi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nomeCl,cognomeCl,numeroCl")] Preventivo preventivo)
        {
            if (id != preventivo.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preventivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PreventivoExists(preventivo.id))
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
            return View(preventivo);
        }

        // GET: Preventivi/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preventivo = await _context.Preventivo
                .FirstOrDefaultAsync(m => m.id == id);
            if (preventivo == null)
            {
                return NotFound();
            }

            return View(preventivo);
        }

        // POST: Preventivi/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var preventivo = await _context.Preventivo.FindAsync(id);
            _context.Preventivo.Remove(preventivo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PreventivoExists(int id)
        {
            return _context.Preventivo.Any(e => e.id == id);
        }
    }
}
