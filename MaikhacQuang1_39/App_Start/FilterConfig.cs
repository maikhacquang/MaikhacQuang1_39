using System.Web;
using System.Web.Mvc;

namespace MaikhacQuang1_39
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
