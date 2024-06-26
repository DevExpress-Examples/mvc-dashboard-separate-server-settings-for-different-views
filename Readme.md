<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579193/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T464543)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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


This example shows how to use separate [DashboardConfigurator](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator) instances within an [ASP.NET MVC Dashboard](https://docs.devexpress.com/Dashboard/16977/web-dashboard/aspnet-mvc-dashboard-extension) application to provide different server-side settings. In this example, the _Sales_ and _Marketing_ views use different dashboard storage and different data connections.

Dashboard controllers are defined in the [Global.asax.cs](./CS/MvcDashboard_ServerSideApi/Global.asax.cs) (VB: [Global.asax.vb](./VB/MvcDashboard_ServerSideApi/Global.asax.vb)) file.

Note that the Web Dashboard control uses a single cache. The use of separate DashboardConfigurator instances does not create separated caches. Create a [custom parameter](https://docs.devexpress.com/Dashboard/118651/web-dashboard/general-information/security-considerations#cache-security) to specify a different cache for different user roles.

## Documentation

- [Manage Multi-Tenancy](https://docs.devexpress.com/Dashboard/402924/web-dashboard/dashboard-backend/manage-multi-tenancy)

## More Examples
- [ASP.NET MVC Dashboard - How to load different data based on the current user](https://github.com/DevExpress-Examples/DashboardDifferentUserDataMVC)
- [ASP.NET MVC Dashboard - How to implement multi-tenant Dashboard architecture](https://github.com/DevExpress-Examples/DashboardUserBasedMVC)
- [ASP.NET Core Dashboard - How to use separate server-side settings for different views](https://github.com/DevExpress-Examples/asp-net-core-dashboard-how-to-use-separate-server-side-settings-for-different-views)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-dashboard-separate-server-settings-for-different-views&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-dashboard-separate-server-settings-for-different-views&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
