using System.Web;
using System.Web.Mvc;

namespace _07_CatchAllSegments {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
