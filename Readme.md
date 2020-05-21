<!-- default file list -->
*Files to look at*:

* [DashboardConfig.cs](./CS/MvcDashboard_ServerSideApi/App_Start/DashboardConfig.cs) (VB: [DashboardConfig.vb](./VB/MvcDashboard_ServerSideApi/App_Start/DashboardConfig.vb))
* [HomeController.cs](./CS/MvcDashboard_ServerSideApi/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcDashboard_ServerSideApi/Controllers/HomeController.vb))
* [Global.asax.cs](./CS/MvcDashboard_ServerSideApi/Global.asax.cs) (VB: [Global.asax.vb](./VB/MvcDashboard_ServerSideApi/Global.asax.vb))
* [Index.cshtml](./CS/MvcDashboard_ServerSideApi/Views/Home/Index.cshtml)
* [MarketingView.cshtml](./CS/MvcDashboard_ServerSideApi/Views/Home/MarketingView.cshtml)
* [SalesView.cshtml](./CS/MvcDashboard_ServerSideApi/Views/Home/SalesView.cshtml)
* [_Layout.cshtml](./CS/MvcDashboard_ServerSideApi/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# ASP.NET MVC Dashboard - How to use separate server-side settings for different views
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t464543/)**
<!-- run online end -->


This example shows how to use separate <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebDashboardConfiguratortopic">DashboardConfigurator</a> instances within an <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument116420">ASP.NET MVC Dashboard</a> application to provide different server-side settings. In this example, the <em>Sales </em>and <em>Marketing </em>views use different dashboard storage and different data connections.

Dashboard controllers are defined in the [Global.asax.cs](./CS/MvcDashboard_ServerSideApi/Global.asax.cs) (VB: [Global.asax.vb](./VB/MvcDashboard_ServerSideApi/Global.asax.vb)) file.

<br/>


