using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PREGUNTA2.Servicios;

namespace PREGUNTA2.Controllers
{
    public class MyDependencyController : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(ProveedorController))
            {
                return new ProveedorController(new MiServicioSQL());
            }
            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Enumerable.Empty<Object>();
        }
    }
}