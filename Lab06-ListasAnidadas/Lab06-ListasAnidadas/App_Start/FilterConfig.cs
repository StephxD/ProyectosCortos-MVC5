using System.Web;
using System.Web.Mvc;

namespace Lab06_ListasAnidadas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
