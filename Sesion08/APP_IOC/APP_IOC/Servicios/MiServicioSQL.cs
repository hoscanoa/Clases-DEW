using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APP_IOC.Models;
using APP_IOC.Controllers;

namespace APP_IOC.Servicios
{
    public class MiServicioSQL:IServicio
    {

        public List<clientes> ListarTodos() { 
          Negocios2015Entities db= new Negocios2015Entities();
          return db.clientes.ToList(); 
        }


    }
}