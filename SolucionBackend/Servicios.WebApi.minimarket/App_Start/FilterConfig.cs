using System.Web;
using System.Web.Mvc;

namespace Servicios.WebApi.minimarket
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
