using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP_IOC.Models;

namespace APP_IOC.Controllers
{
    public interface IServicio
    {
        List<clientes> ListarTodos();

    }
}
