using DEVICE.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVICE.Web.Repos
{
    public class ProductoRepo
    {
        public ProductoRepo()
        {

        }

        public static async Task<IEnumerable<Producto>> ObtenerProducto()
        {
            using var data = new DeviceDBContext();
            return await data.Producto.ToListAsync();
        }

        public static async Task<Producto> ObtenerProductoPorID(int id)
        {
            using var data = new DeviceDBContext();
            return await data.Producto.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public static async Task<bool> RegistrarProducto(Producto producto)
        {
            bool exito = true;
            try
            {
                using var data = new DeviceDBContext();
                producto.Estado = true;
                producto.SistemaOperativoId = (producto.SistemaOperativoId == -1 ? null : producto.SistemaOperativoId);
                producto.FabricanteId = (producto.FabricanteId == -1 ? null : producto.FabricanteId);
                producto.ProcesadorId = (producto.ProcesadorId == -1 ? null : producto.ProcesadorId);
                data.Producto.Add(producto);
                await data.SaveChangesAsync();
            }
            catch
            {
                exito = false;
            }
            return exito;
        }

        public static async Task<bool> EliminarProducto(int id)
        {
            bool exito = true;
            try
            {
                using var data = new DeviceDBContext();

                var producto = data.Producto.Where(x => x.Id == id).FirstOrDefault();
                //data.Remove(producto);
                producto.Estado = false;
                await data.SaveChangesAsync();
            }
            catch
            {
                exito = false;
            }
            return exito;
        }

        public static async Task<bool> ActualizarProducto(Producto producto)
        {
            bool exito = true;
            try
            {
                using var data = new DeviceDBContext();

                var productoActual = data.Producto.Where(x => x.Id == producto.Id).FirstOrDefault();
                productoActual.Comentario = producto.Comentario;
                productoActual.TipoProductoId = producto.TipoProductoId;
                productoActual.NumeroSerie = producto.NumeroSerie;
                productoActual.NumeroProducto = producto.NumeroProducto;
                productoActual.MemoriaRam = producto.MemoriaRam;
                productoActual.Modelo = producto.Modelo;
                productoActual.SistemaOperativoId = producto.SistemaOperativoId;
                productoActual.FabricanteId = producto.FabricanteId;
                productoActual.ProcesadorId = producto.ProcesadorId;
                productoActual.IP = producto.IP;
                productoActual.Usuario = producto.Usuario;
                productoActual.Password = producto.Password;
                productoActual.SSIDNombre = producto.SSIDNombre;
                productoActual.SSIDPassword = producto.SSIDPassword;

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
