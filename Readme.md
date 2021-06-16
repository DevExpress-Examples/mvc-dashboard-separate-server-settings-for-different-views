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


This example shows how to use separate [DashboardConfigurator](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator) instances within an [ASP.NET MVC Dashboard](https://docs.devexpress.com/Dashboard/16977/web-dashboard/aspnet-mvc-dashboard-extension) application to provide different server-side settings. In this example, the _Sales_ and _Marketing_ views use different dashboard storage and different data connections.

Dashboard controllers are defined in the [Global.asax.cs](./CS/MvcDashboard_ServerSideApi/Global.asax.cs) (VB: [Global.asax.vb](./VB/MvcDashboard_ServerSideApi/Global.asax.vb)) file.

Note that the Web Dashboard control uses a single cache. The use of separate DashboardConfigurator instances does not create separated caches. Create a [custom parameter](https://docs.devexpress.com/Dashboard/118651/web-dashboard/general-information/security-considerations#cache-security) to specify a different cache for different user roles.

## Documentation

- [Manage Multi-Tenancy](https://docs.devexpress.com/Dashboard/402924/web-dashboard/dashboard-backend/manage-multi-tenancy)

## More Examples
- [ASP.NET MVC Dashboard - How to load different data based on the current user](https://github.com/DevExpress-Examples/DashboardDifferentUserDataMVC)
- [ASP.NET MVC Dashboard - How to implement multi-tenant Dashboard architecture](https://github.com/DevExpress-Examples/DashboardUserBasedMVC)
