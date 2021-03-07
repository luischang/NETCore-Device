using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVICE.Web.Areas.Equipo.Controllers
{
    [Area(nameof(Equipo))]
    public class EntregaController : Controller
    {
        public IActionResult Index()
        {
         
            return View();
        }
    }
}
