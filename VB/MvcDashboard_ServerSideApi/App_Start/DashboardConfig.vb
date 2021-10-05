Imports DevExpress.DashboardWeb.Mvc
Imports System.Web.Routing

Public Class DashboardConfig
	Public Shared Sub RegisterService(ByVal routes As RouteCollection)
		routes.MapDashboardRoute("MarketingDashboard", "MarketingDashboard")
		routes.MapDashboardRoute("SalesDashboard", "SalesDashboard")
	End Sub
End Class