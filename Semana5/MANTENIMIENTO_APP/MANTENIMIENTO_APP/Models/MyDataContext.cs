using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace MANTENIMIENTO_APP.Models
{
    public class MyDataContext:DbContext
    {
        public DbSet<Producto> listaProducto { get; set; }
        public DbSet<Categoria> listaCategoria { get; set; }
        public DbSet<Proveedor> listaProveedor { get; set; }
        public DbSet<Empleado> listaEmpleado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
    }
}