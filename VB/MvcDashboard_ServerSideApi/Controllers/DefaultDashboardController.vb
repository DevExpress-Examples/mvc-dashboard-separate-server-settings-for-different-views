Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc

Namespace MvcDashboard_ServerSideApi.Controllers
	Public Class DefaultDashboardController
		Inherits DashboardController

		Public Sub New(ByVal dashboardConfigurator As DashboardConfigurator)
			MyBase.New(dashboardConfigurator)

		End Sub
	End Class
End Namespace