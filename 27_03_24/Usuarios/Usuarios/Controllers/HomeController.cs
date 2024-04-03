using Microsoft.AspNetCore.Mvc;
using Usuarios.Models;
using System.Diagnostics;

namespace Usuarios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatosContext _context;

        public HomeController(ILogger<HomeController> logger, DatosContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var empleados = _context.Empleados.ToList();
            return View(empleados);
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
