﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DEVICE.Web.Models
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            SucursalDepartamento = new HashSet<SucursalDepartamento>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? ZonaId { get; set; }

        public virtual Zona Zona { get; set; }
        public virtual ICollection<SucursalDepartamento> SucursalDepartamento { get; set; }
    }
}
