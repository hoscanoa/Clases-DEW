﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PREGUNTA2.Models;
using PREGUNTA2.Controllers;

namespace PREGUNTA2.Servicios
{
    public class MiServicioSQL : IServicio
    {
        public List<clientes> ListarTodos()
        {
            Negocios2015Entities db = new Negocios2015Entities();
            return db.clientes.ToList();
        }
    }
}