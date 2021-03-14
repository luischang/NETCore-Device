using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVICE.Web.Models
{
    public class SucursalProducto
    {
        public SucursalProducto()
        {
           
        }

        public int Id { get; set; }     
        public int? ProductoId { get; set; }
        public int? SucursalId { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Estado { get; set; }
        public string Comentario { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
