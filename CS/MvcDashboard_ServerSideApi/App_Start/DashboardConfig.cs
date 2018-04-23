using DevExpress.DashboardWeb.Mvc;
using System.Web.Routing;

public class DashboardConfig {
    public static void RegisterService(RouteCollection routes) {
        routes.MapDashboardRoute("MarketingDashboard", "MarketingDashboard", new[] { "MvcDashboard_ServerSideApi" } );
        routes.MapDashboardRoute("SalesDashobard", "SalesDashobard", new[] { "MvcDashboard_ServerSideApi" });
    }
}