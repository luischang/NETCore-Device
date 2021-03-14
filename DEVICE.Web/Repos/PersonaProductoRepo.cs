using DEVICE.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVICE.Web.Repos
{
    public class PersonaProductoRepo
    {

        public static async Task<IEnumerable<PersonaProducto>> ObtenerPersonaProducto()
        {
            using var data = new DeviceDBContext();
            return await data.PersonaProducto.ToListAsync();
        }

        public static async Task<PersonaProducto> ObtenerPersonaProductoPorID(int id)
        {
            using var data = new DeviceDBContext();
            return await data.PersonaProducto.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public static async Task<bool> RegistrarPersonaProducto(PersonaProducto personaProducto)
        {
            bool exito = true;
            try
            {
                using var data = new DeviceDBContext();
                data.PersonaProducto.Add(personaProducto);              
                await data.SaveChangesAsync();
            }
            catch
            {
                exito = false;
            }
            return exito;
        }



    }
}
