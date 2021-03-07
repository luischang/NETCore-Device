using System;
using System.Collections.Generic;

#nullable disable

namespace DEVICE.Web.Models
{
    public partial class PersonaProducto
    {
        public PersonaProducto()
        {
            PersonaProductoEvidencia = new HashSet<PersonaProductoEvidencia>();
        }

        public int Id { get; set; }
        public int? PersonaId { get; set; }
        public int? ProductoId { get; set; }
        public DateTime? FechaAsignacionIp { get; set; }
        public string NumeroIp { get; set; }
        public DateTime? FechaProximaCambio { get; set; }
        public string FechaEntrega { get; set; }
        public bool? Estado { get; set; }

        public virtual Persona Persona { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual ICollection<PersonaProductoEvidencia> PersonaProductoEvidencia { get; set; }
    }
}
