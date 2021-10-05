Imports System
Imports System.Web.Hosting
Imports System.Web.Mvc
Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.Web
Imports MvcDashboard_ServerSideApi.Controllers

Namespace MvcDashboard_ServerSideApi
	Public Class MvcApplication
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start()
			DashboardConfig.RegisterService(RouteTable.Routes)
			RouteConfig.RegisterRoutes(RouteTable.Routes)
			AddHandler ASPxWebControl.CallbackError, AddressOf Application_Error
			ControllerBuilder.Current.SetControllerFactory(GetType(CustomControllerFactory))
		End Sub

		Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
			Dim exception As Exception = System.Web.HttpContext.Current.Server.GetLastError()
		End Sub
	End Class

	Public Class CustomControllerFactory
		Inherits DefaultControllerFactory

		Public Overrides Function CreateController(ByVal requestContext As RequestContext, ByVal controllerName As String) As IController
			If controllerName = "SalesDashboard" Then
				Dim salesConfigurator As New DashboardConfigurator()
				salesConfigurator.SetDashboardStorage(New DashboardFileStorage("~/App_Data/Sales"))
				AddHandler salesConfigurator.ConfigureDataConnection, Sub(s, e)
					Dim databasePath As String = HostingEnvironment.MapPath("~/App_Data/nwind.mdb")
					If e.ConnectionName = "Northwind connection" Then
						e.ConnectionParameters = New Access97ConnectionParameters(databasePath, "", "")
					End If
				End Sub
				Return New DefaultDashboardController(salesConfigurator)
			ElseIf controllerName = "MarketingDashboard" Then
				Dim marketingConfigurator As New DashboardConfigurator()
				marketingConfigurator.SetDashboardStorage(New DashboardFileStorage("~/App_Data/Marketing"))
				AddHandler marketingConfigurator.ConfigureDataConnection, Sub(s, e)
					Dim connectionString As String = "provider=MSOLAP;" & ControlChars.CrLf & _
"                                  data source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" & ControlChars.CrLf & _
"                                  initial catalog=Adventure Works DW Standard Edition;" & ControlChars.CrLf & _
"                                  cube name=Adventure Works;"
					If e.ConnectionName = "Adventure Works connection" Then
						e.ConnectionParameters = New OlapConnectionParameters(connectionString)
					End If
				End Sub
				Return New DefaultDashboardController(marketingConfigurator)
			Else
				Return MyBase.CreateController(requestContext, controllerName)
			End If
		End Function

		Public Overrides Sub ReleaseController(ByVal controller As IController)
'INSTANT VB NOTE: The variable dispose was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim dispose_Renamed As IDisposable = TryCast(controller, IDisposable)
			If dispose_Renamed IsNot Nothing Then
				dispose_Renamed.Dispose()
			End If
		End Sub
	End Class
End Namespace