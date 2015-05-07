using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace APP_MANTENIMIENTO.Models
{
    public class MyDataContext : DbContext
    {
        public DbSet<Empleado> listEmpleados { get; set; }
        public DbSet<Producto> listProductos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}