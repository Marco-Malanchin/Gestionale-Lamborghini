using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LamborghiniAuto.Data;
using LamborghiniAuto.Models;
using Microsoft.AspNetCore.Authorization;

namespace LamborghiniAuto.Controllers
{
    public class VenditeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VenditeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // [Authorize] --> Deve essere fatto il login

        // GET: Vendite
        [Authorize]
        public async Task<IActionResult> Index()
        {
            List<string> modelliVendite = new List<string>();
            List<Vendita> vendite = await _context.Vendita.ToListAsync(); // Lista che contiene tutte le vendite contenute nel database
            vendite.Reverse();
            foreach (var item in vendite)
            {
                Auto auto = _context.Auto.Where(a => a.id == item.idMacchina).FirstOrDefault(); // Viene presa dal database ogni macchina all'interno della vendita tramite una query
                modelliVendite.Add(auto.modello); // Viene aggiunto alla lista il modello della auto della vendita
            }
            var tuple = new Tuple<List<Vendita>, List<string>>(vendite, modelliVendite); // Tuple (struttura dati) che contiene una coppia di valori, cioè la lista delle vendite e la lista dei modelli delle auto di ogni vendita 
            return View(tuple);
        }

        // GET: Vendite/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) // Se l'id "inserito" non esiste
            {
                ViewBag.Message = "Vendita inesistente"; // Messaggio che viene mostrato nella View Errore
                return View("Errore");
            }

            var vendita = await _context.Vendita
                .FirstOrDefaultAsync(m => m.id == id); // Viene estrapolata dal database la vendita che ha l'id inserito
            if (vendita == null) // Se la vendita non esiste
            {
                ViewBag.Message = "Vendita inesistente";
                return View("Errore");
            }

            return View(vendita);
        }

        // GET: Vendite/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendite/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("id,nome,cognome,codFisc,dataVendita,idMacchina")] Vendita vendita)
        {
            if (!_context.Cliente.Any(c => c.nome.Equals(vendita.nome) && c.cognome.Equals(vendita.cognome) && c.codFisc.Equals(vendita.codFisc))) // Se i campi inseriti nel form della vendita non sono trovati in un determinato cliente
            {
                ViewBag.Message = "Cliente inesistente"; // Messaggio che viene mostrato nella View Errore
                return View("Errore");
            }
            if (!_context.Auto.Any(a => a.id.Equals(vendita.idMacchina))) // Se l'auto inserita non corrisponde a nessuna auto, controllo avvenuto attraverso gli id dell'auto della vendita e le auto che sono nel db
            {
                ViewBag.Message = "Auto inesistente"; // Messaggio che viene mostrato nella View Errore
                return View("Errore");
            }
            if (vendita.dataVendita > DateTime.Now || vendita.dataVendita.Year < 2010 )
            {
                ViewBag.Message = "Data errata"; // Messaggio che viene mostrato nella View Errore
                return View("Errore");
            }

            if (ModelState.IsValid)
            {
                Auto auto = _context.Auto.Where(a => a.id.Equals(vendita.idMacchina)).FirstOrDefault(); // Viene presa la macchina che è stata inserita nella vendita
                Cliente cliente = _context.Cliente.Where(c => c.cognome.Equals(vendita.nome) && c.nome.Equals(vendita.cognome)).FirstOrDefault(); // Viene preso il cliente inserito nella vendita
                Finanza finanza = _context.Finanza.Where(c => c.id.Equals(1)).FirstOrDefault();
                if (auto.pezziDisponibili < 1)
                {
                    ViewBag.Message = "Macchina non disponibile, pezzi insufficienti"; // Messaggio che viene mostrato nella View Errore
                    return View("Errore");
                }
                auto.pezziDisponibili -= 1;
                auto.PezziVenduti += 1;
                finanza.entrate += auto.prezzo * 1.15;
                _context.Update(finanza);
                _context.Update(auto); // Aggiornati i nuovi valori
                _context.Add(vendita); // Aggiunta della vendita
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendita);
        }

        // GET: Vendite/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                ViewBag.Message = "Vendita inesistente";
                return View("Errore");
            }

            var vendita = await _context.Vendita.FindAsync(id);
            if (vendita == null)
            {
                ViewBag.Message = "Vendita inesistente";
                return View("Errore");
            }
            return View(vendita);
        }

        // POST: Vendite/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("id,nome,cognome,dataVendita,codFisc,idMacchina")] Vendita vendita)
        {
            if (id != vendita.id)
            {
                return NotFound();
            }

            if (!_context.Cliente.Any(c => c.nome.Equals(vendita.nome) && c.cognome.Equals(vendita.cognome) && c.codFisc.Equals(vendita.codFisc))) // Se i campi inseriti nel form della vendita non sono trovati in un determinato cliente
            {
                ViewBag.Message = "Cliente inesistente";
                return View("Errore");
            }
            if (!_context.Auto.Any(a => a.id.Equals(vendita.idMacchina))) // Se l'auto inserita non corrisponde a nessuna auto, controllo avvenuto attraverso gli id dell'auto della vendita e le auto che sono nel db
            {
                ViewBag.Message = "Auto inesistente";
                return View("Errore");
            }
            if (vendita.dataVendita > DateTime.Now || vendita.dataVendita.Year < 2010)
            {
                ViewBag.Message = "Data errata";
                return View("Errore");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendita); // Vengono aggiornate le modifiche della vendita
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VenditaExists(vendita.id))
                    {
                        ViewBag.Message = "Vendita inesistente";
                        return View("Errore");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vendita);
        }

        // GET: Vendite/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                ViewBag.Message = "Vendita inesistente";
                return View("Errore");
            }

            var vendita = await _context.Vendita
                .FirstOrDefaultAsync(m => m.id == id);
            if (vendita == null)
            {
                ViewBag.Message = "Vendita inesistente";
                return View("Errore");
            }

            return View(vendita);
        }

        // POST: Vendite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendita = await _context.Vendita.FindAsync(id);
            var auto = _context.Auto.Where(a => a.id.Equals(vendita.idMacchina)).FirstOrDefault();
            Finanza finanza = _context.Finanza.Where(c => c.id.Equals(1)).FirstOrDefault();
            auto.pezziDisponibili += 1;
            auto.PezziVenduti -= 1;
            finanza.entrate -= auto.prezzo * 1.15;
            _context.Update(auto);
            _context.Vendita.Remove(vendita);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VenditaExists(int id)
        {
            return _context.Vendita.Any(e => e.id == id);
        }
    }
}
