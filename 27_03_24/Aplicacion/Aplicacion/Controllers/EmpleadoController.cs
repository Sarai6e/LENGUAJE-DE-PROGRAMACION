using Microsoft.AspNetCore.Mvc;
using Aplicacion.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Aplicacion.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmpleadoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var empleados = _context.Empleados.ToList();
            return View(empleados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre,Apellido,DNI,Cargo,NumeroCelular,FechaNacimiento,Domicilio")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }
    }
}
