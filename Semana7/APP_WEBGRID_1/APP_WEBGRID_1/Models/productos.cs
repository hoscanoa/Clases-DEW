//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APP_WEBGRID_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class productos
    {
        public int IdProducto { get; set; }
        public string NomProducto { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public string CantxUnidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public short UnidadesEnExistencia { get; set; }
        public short UnidadesEnPedido { get; set; }
        public Nullable<bool> Activo { get; set; }
    }
}
