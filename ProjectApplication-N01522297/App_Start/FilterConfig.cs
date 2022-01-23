using System.Web;
using System.Web.Mvc;

namespace ProjectApplication_N01522297
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
