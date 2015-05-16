using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PREGUNTA2.Models;

namespace PREGUNTA2.Controllers
{
    public interface IServicio
    {
        List<clientes> ListarTodos();
    }
}
