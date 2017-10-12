using System.Web;
using System.Web.Mvc;

namespace Oct11_2017Bookshelf
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
