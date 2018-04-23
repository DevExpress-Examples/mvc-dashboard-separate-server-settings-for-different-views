using System.Web.Mvc;

namespace MVCDashboard_ServerSideAPI.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult SalesDashboards() {
            return View("SalesView");
        }
        public ActionResult MarketingDashboards() {
            return View("MarketingView");
        }
    }
}