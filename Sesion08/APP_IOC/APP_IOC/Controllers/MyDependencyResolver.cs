using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//estos han sido incluidos
using System.Web.Mvc;
using APP_IOC.Servicios;

namespace APP_IOC.Controllers
{
    public class MyDependencyResolver: IDependencyResolver
    {

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(ClienteController)) {
                return new ClienteController(new MiServicioSQL());
            }
            return null;

        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Enumerable.Empty<Object>();
        }
    }
}