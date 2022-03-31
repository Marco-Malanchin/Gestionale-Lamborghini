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
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cliente
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cliente.ToListAsync());
        }

        // GET: Cliente/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                ViewBag.Message = "Cliente inesistente";
                return View("Errore");
            }

            var cliente = await _context.Cliente
                .FirstOrDefaultAsync(m => m.id == id); // Prende il cliente che ha l'id inserito
            if (cliente == null)
            {
                ViewBag.Message = "Cliente inesistente";
                return View("Errore");
            }

            return View(cliente);
        }

        // GET: Cliente/Create
        [Authorize]
        public IActionResult AggiuntaCliente()
        {
            return View();
        }

        // POST: Cliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> AggiuntaCliente([Bind("id,nome,cognome,codFisc,dataNascita")] Cliente cliente)
        {
            if (_context.Cliente.Any(c => c.codFisc.Equals(cliente.codFisc))) // Se il codice fiscale inserito esiste già, lo controlla facendo una query, andando a controllare se un cliente ha lo stesso CF di quello che è stato inserito
            {
                ViewBag.Message = "Codice fiscale già inserito";
                return View("Errore");
            }

            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Cliente/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                ViewBag.Message = "Cliente inesistente";
                return View("Errore");
            }

            var cliente = await _context.Cliente.FindAsync(id); // Prende il cliente che ha l'id inserito
            if (cliente == null)
            {
                ViewBag.Message = "Cliente inesistente";
                return View("Errore");
            }
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nome,cognome,codFisc,dataNascita")] Cliente cliente)
        {
            if (id != cliente.id)
            {
                ViewBag.Message = "Cliente errato";
                return View("Errore");
            }

            if (_context.Cliente.Any(c => c.codFisc.Equals(cliente.codFisc))) // Se il codice fiscale inserito esiste già, lo controlla facendo una query, andando a controllare se un cliente ha lo stesso CF di quello che è stato inserito
            {
                ViewBag.Message = "Codice fiscale già inserito";
                return View("Errore");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.id))
                    {
                        ViewBag.Message = "Cliente inesistente";
                        return View("Errore");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Cliente/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                ViewBag.Message = "Cliente inesistente";
                return View("Errore");
            }

            var cliente = await _context.Cliente
                .FirstOrDefaultAsync(m => m.id == id); // Viene preso il cliente che ha l'id selezionato
            if (cliente == null)
            {
                ViewBag.Message = "Cliente inesistente";
                return View("Errore");
            }

            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.id == id);
        }
    }
}
