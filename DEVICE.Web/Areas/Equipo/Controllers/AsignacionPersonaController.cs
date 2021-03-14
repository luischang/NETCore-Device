using DEVICE.Web.Models;
using DEVICE.Web.Repos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DEVICE.Web.Areas.Equipo.Controllers
{
    [Area(nameof(Equipo))]
    public class AsignacionPersonaController : Controller
    {
        private readonly IHostingEnvironment _env;

        public AsignacionPersonaController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listado()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> Grabar()
        {
            string fechaEntrega =Request.Form.Where(x => x.Key == "vFechaEntrega").FirstOrDefault().Value;
            string comentario = Request.Form.Where(x => x.Key == "vComentario").FirstOrDefault().Value;
            var fileFirma = Request.Form.Files.Count == 0 ? null : Request.Form.Files[0];
            var fileFoto = Request.Form.Files.Count == 0 ? null : Request.Form.Files[1];


            string fileNameFirma = Guid.NewGuid().ToString() + Path.GetExtension(fileFirma.FileName).ToLowerInvariant();
            string fileNameFoto = DateTime.Now.ToFileTime().ToString() + Path.GetExtension(fileFoto.FileName).ToLowerInvariant();

            var asignacion = new PersonaProducto()
            {
                PersonaId = 1,
                ProductoId = 4,
                FechaProximaCambio = null,
                FechaEntrega = null,
                Comentario = comentario,
                Estado = true
            };

            bool exito = await PersonaProductoRepo.RegistrarPersonaProducto(asignacion);

            if (fileFirma != null)
            {      
                var filePath = Path.Combine(_env.ContentRootPath + "/Documents/AsignacionPersona/",
                    fileNameFirma);

                using var stream = System.IO.File.Create(filePath);
                await fileFirma.CopyToAsync(stream);
            }

            if (fileFoto != null)
            {
                var filePath = Path.Combine(_env.ContentRootPath + "/Documents/AsignacionPersona/",
                    fileNameFoto);

                using var stream = System.IO.File.Create(filePath);
                await fileFoto.CopyToAsync(stream);
            }



            return Json("OK");
        }
    }
}
