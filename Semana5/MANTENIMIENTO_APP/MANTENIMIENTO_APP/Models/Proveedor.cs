using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANTENIMIENTO_APP.Models
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

        public List<Producto> productos { get; set; }
    }
}