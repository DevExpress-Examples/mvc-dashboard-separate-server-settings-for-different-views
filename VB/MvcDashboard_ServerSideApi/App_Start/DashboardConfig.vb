Imports System.Web.Routing
Imports DevExpress.DashboardWeb.Mvc

Public Class DashboardConfig
    Public Shared Sub RegisterService(ByVal routes As RouteCollection)
        routes.MapDashboardRoute("MarketingDashboard", "MarketingDashboard", {"MVCDashboard_ServerSideAPI"})
        routes.MapDashboardRoute("SalesDashboard", "SalesDashboard", {"MVCDashboard_ServerSideAPI"})
    End Sub
End Class