using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APP_MANTENIMIENTO.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public string Stock { get; set; }
        public string Precio { get; set; }
        public string Ubicacion { get; set; }
    }
}