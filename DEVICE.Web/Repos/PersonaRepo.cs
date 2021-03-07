using DEVICE.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVICE.Web.Repos
{
    public class PersonaRepo
    {
        public static async Task<Persona> GetPersonaPorCredenciales(string usuario, string password)
        {
            using var data = new DeviceDBContext();
            return await data.Persona.Where(z => z.Usuario == usuario && z.Password == password).FirstOrDefaultAsync();
        }



    }
}
