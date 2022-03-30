﻿using System;
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
    public class AutoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AutoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Auto
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Auto.ToListAsync());
        }

        public async Task<IActionResult> Preventivo(int? id)
        {
            if (id == null)
            {
                return View("Errore");
            }

            var auto = await _context.Auto.FirstOrDefaultAsync(a => a.id == id);
            if (auto == null)
            {
                return View("Errore");
            }

            return View(auto);
        }


        // GET: Auto/Ordina/id
        [Authorize]
        public IActionResult Ordina(int? id)
        {
            if (id == null)
            {
                return View("Errore");
            }
            var auto = _context.Auto.FirstOrDefault(a => a.id == id);
            if (auto == null)
            {              
                return View("Errore");
            }
            return View(auto);
        }

        //POST: Auto/Ordina/id
        [ValidateAntiForgeryToken]
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Ordina(int? id, int nuoviPezzi)
        {
            var auto = await _context.Auto.FirstOrDefaultAsync(a => a.id == id);
            var finanza = await _context.Finanza.FirstOrDefaultAsync(f => f.id == 1);
            if (auto == null && id == null)
            {
                ViewBag.Message = "Macchina inesistente";
                return View("Errore");
            }
            if (nuoviPezzi <= 0)
            {
                ViewBag.Message = "Inserire un numero maggiore di 0";
                return View("Errore");
            }
            finanza.uscite += auto.prezzo;
            auto.pezziDisponibili += nuoviPezzi;
            _context.Update(auto);
            _context.Update(finanza);
            _context.SaveChanges();
            return View();
        }

        // GET: Auto/Details/5
        [Authorize]
        public async Task<IActionResult> MostraInfo(int? id)
        {
            if (id == null)
            {
                ViewBag.Message = "Macchina inesistente";
                return View("Errore");
            }

            var auto = await _context.Auto
                .FirstOrDefaultAsync(m => m.id == id);
            if (auto == null)
            {
                ViewBag.Message = "Macchina inesistente";
                return View("Errore");
            }

            return View(auto);
        }

        // GET: Auto/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Auto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,modello,prezzo,potenza,info,pezziVenduti,pezziDisponibili")] Auto auto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(auto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(auto);
        }

        // GET: Auto/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auto = await _context.Auto.FindAsync(id);
            if (auto == null)
            {
                return NotFound();
            }
            return View(auto);
        }

        // POST: Auto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,modello,prezzo,potenza,info,pezziVenduti,pezziDisponibili")] Auto auto)
        {
            if (id != auto.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoExists(auto.id))
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
            return View(auto);
        }

        // GET: Auto/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auto = await _context.Auto
                .FirstOrDefaultAsync(m => m.id == id);
            if (auto == null)
            {
                return NotFound();
            }

            return View(auto);
        }

        // POST: Auto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var auto = await _context.Auto.FindAsync(id);
            _context.Auto.Remove(auto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoExists(int id)
        {
            return _context.Auto.Any(e => e.id == id);
        }
    }
}
