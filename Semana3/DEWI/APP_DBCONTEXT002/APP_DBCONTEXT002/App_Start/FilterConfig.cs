﻿using System.Web;
using System.Web.Mvc;

namespace APP_DBCONTEXT002
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}