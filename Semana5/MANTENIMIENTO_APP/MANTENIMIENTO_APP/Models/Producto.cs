using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MANTENIMIENTO_APP.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        [Required(ErrorMessage="Dato obligatorio...")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Dato obligatorio..."),Range(1,500,ErrorMessage="Precio Fuera de Range")]
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }
        public int ProveedorId { get; set; }

        public virtual Categoria categoria { get; set; }
        public virtual Proveedor proveedor { get; set; }

    }
}