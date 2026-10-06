using System.Web;
using System.Web.Mvc;

namespace Nguyễn_Đức_Kiên___KtraFE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
