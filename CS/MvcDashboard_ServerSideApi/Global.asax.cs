using System;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Routing;
using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.Web;

namespace MvcDashboard_ServerSideApi {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            ControllerBuilder.Current.SetControllerFactory(typeof(RestrictedControllerFactory));
            DashboardConfig.RegisterService(RouteTable.Routes);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ASPxWebControl.CallbackError += Application_Error;
            ControllerBuilder.Current.SetControllerFactory(typeof(CustomControllerFactory));
        }

        protected void Application_Error(object sender, EventArgs e) {
            Exception exception = System.Web.HttpContext.Current.Server.GetLastError();
        }
    }

    public class CustomControllerFactory : DefaultControllerFactory {
        public override IController CreateController(RequestContext requestContext, string controllerName) {
            if (controllerName == "SalesDashboard") {
                DashboardConfigurator salesConfigurator = new DashboardConfigurator();
                salesConfigurator.SetDashboardStorage(new DashboardFileStorage(@"~/App_Data/Sales"));
                salesConfigurator.ConfigureDataConnection += (s, e) => {
                    string databasePath = HostingEnvironment.MapPath("~/App_Data/nwind.mdb");
                    if (e.ConnectionName == "Northwind connection")
                        e.ConnectionParameters = new Access97ConnectionParameters(databasePath, "", "");
                };
                return new DashboardController(salesConfigurator);
            }
            else if (controllerName == "MarketingDashboard") {
                DashboardConfigurator marketingConfigurator = new DashboardConfigurator();
                marketingConfigurator.SetDashboardStorage(new DashboardFileStorage(@"~/App_Data/Marketing"));
                marketingConfigurator.ConfigureDataConnection += (s, e) => {
                    string connectionString = @"provider=MSOLAP;
                                  data source=https://demos.devexpress.com/Services/OLAP/msmdpump.dll;
                                  initial catalog=Adventure Works DW Standard Edition;
                                  cube name=Adventure Works;";
                    if (e.ConnectionName == "Adventure Works connection")
                        e.ConnectionParameters = new OlapConnectionParameters(connectionString);
                };
                return new DashboardController(marketingConfigurator);
            }
            else {
                return base.CreateController(requestContext, controllerName);
            }
        }

        public override void ReleaseController(IController controller) {
            IDisposable dispose = controller as IDisposable;
            if (dispose != null) {
                dispose.Dispose();
            }
        }
    }
}