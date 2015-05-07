using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANTENIMIENTO_APP.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }

        public List<Producto> productos { get; set; }



    }
}