using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVICE.Web.Controllers
{
    public class SeguridadController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string codigo, string contrasena)
        {
            return RedirectToAction("Dashboard", "Main", new { area = "Administrativo" });
        }
    }
}
