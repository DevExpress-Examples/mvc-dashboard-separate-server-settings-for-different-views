Imports System.Web.Mvc

Namespace MVCDashboard_ServerSideAPI.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function SalesDashboards() As ActionResult
            Return View("SalesView")
        End Function
        Public Function MarketingDashboards() As ActionResult
            Return View("MarketingView")
        End Function
    End Class
End Namespace