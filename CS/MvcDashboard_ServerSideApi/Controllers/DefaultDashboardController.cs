using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;

namespace MvcDashboard_ServerSideApi.Controllers {
    public class DefaultDashboardController : DashboardController {
        public DefaultDashboardController(DashboardConfigurator dashboardConfigurator) 
            : base(dashboardConfigurator) {
            
        }
    }
}