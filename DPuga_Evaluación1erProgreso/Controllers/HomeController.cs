using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DPuga_Evaluación1erProgreso.Models;
using DPuga_Evaluación1erProgreso.Data;
using System.Diagnostics;

namespace DPuga_Evaluación1erProgreso.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DPuga_Evaluación1erProgresoContext _context;

        public HomeController(ILogger<HomeController> logger, DPuga_Evaluación1erProgresoContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public async Task<IActionResult> Privacy()
        {
            var clientes = await _context.DPugaClientes.ToListAsync(); // Cargamos todos los clientes
            return View(clientes); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
