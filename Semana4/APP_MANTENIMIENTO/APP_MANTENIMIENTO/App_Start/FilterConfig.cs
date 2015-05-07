using System.Web;
using System.Web.Mvc;

namespace APP_MANTENIMIENTO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}