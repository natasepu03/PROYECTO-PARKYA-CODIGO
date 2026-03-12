using Microsoft.AspNetCore.Mvc;
using ParkYa.Data;
using ParkYa.Models;
using ParkYa.Models.ViewModels;
using System.Linq;

namespace ParkYa.Controllers
{
    public class AutenticacionController : Controller
    {
        private readonly ParkYaDbContext _context;

        public AutenticacionController(ParkYaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var usuario = _context.usuario.FirstOrDefault(u => u.correo == model.Correo);

            if (usuario == null)
            {
                ViewBag.Error = "El correo no está registrado";
                return View(model);
            }

            if (usuario.contraseña != model.Password)
            {
                ViewBag.Error = "Contraseña incorrecta";
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}