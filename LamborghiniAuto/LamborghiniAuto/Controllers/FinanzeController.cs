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
    public class FinanzeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FinanzeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Finanze
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var finanze = await _context.Finanza.FirstOrDefaultAsync(f => f.id == 1); // Vengono prese le finanze dal db
            var dipendenti = await _context.Dipendente.ToListAsync(); // Vengono presi i dipendenti, per poi aggiungere alle uscite gli stipendi di quest'ultimi
            foreach (var dipendente in dipendenti)
            {
                finanze.uscite += dipendente.stipendio * 12;
            }
            finanze.ricavi = finanze.entrate - finanze.uscite;
            return View(await _context.Finanza.ToListAsync());
        }

        // GET: Finanze/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) 
            {
                return NotFound();
            }

            var finanza = await _context.Finanza
                .FirstOrDefaultAsync(m => m.id == id);
            if (finanza == null)
            {
                return NotFound();
            }

            return View(finanza);
        }

        // GET: Finanze/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Finanze/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,entrate,uscite,ricavi")] Finanza finanza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(finanza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(finanza);
        }

        // GET: Finanze/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finanza = await _context.Finanza.FindAsync(id);
            if (finanza == null)
            {
                return NotFound();
            }
            return View(finanza);
        }

        // POST: Finanze/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,entrate,uscite,ricavi")] Finanza finanza)
        {
            if (id != finanza.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(finanza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinanzaExists(finanza.id))
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
            return View(finanza);
        }

        // GET: Finanze/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finanza = await _context.Finanza
                .FirstOrDefaultAsync(m => m.id == id);
            if (finanza == null)
            {
                return NotFound();
            }

            return View(finanza);
        }

        // POST: Finanze/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var finanza = await _context.Finanza.FindAsync(id);
            _context.Finanza.Remove(finanza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FinanzaExists(int id)
        {
            return _context.Finanza.Any(e => e.id == id);
        }
    }
}
