using LamborghiniAuto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LamborghiniAuto.Data;
using Microsoft.EntityFrameworkCore;

namespace LamborghiniAuto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Catalogo()
        {
            return View();
        }

        public IActionResult Aventador_svj()
        {
            return View(_context.Auto.FirstOrDefault(a => a.modello.Contains("Aventador")));
        }
        public IActionResult STO ()
        {
            return View(_context.Auto.FirstOrDefault(a => a.modello.Contains("STO")));
        }
        public IActionResult Urus()
        {
            return View(_context.Auto.FirstOrDefault(a => a.modello.Contains("Urus")));
        }
        public IActionResult countach()
        {
            return View(_context.Auto.FirstOrDefault(a => a.modello.Contains("Countach")));
        }
        public IActionResult sian()
        {
            return View(_context.Auto.FirstOrDefault(a => a.modello.Contains("Sian")));
        }

        public IActionResult PersMag()
        {
            var tuple = new Tuple<List<Cliente>, List<Auto>, List<Dipendente>>(_context.Cliente.ToList(), _context.Auto.ToList(), _context.Dipendente.ToList());
            return View(tuple);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
