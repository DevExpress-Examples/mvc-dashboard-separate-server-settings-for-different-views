Imports System
Imports System.Web.Hosting
Imports System.Web.Mvc
Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.Web

Namespace MVCDashboard_ServerSideAPI
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

        Public Overrides Function CreateController(ByVal requestContext As RequestContext,
                                                   ByVal controllerName As String) As IController
            If controllerName = "SalesDashobard" Then
                Dim salesConfigurator As New DashboardConfigurator()
                salesConfigurator.SetDashboardStorage(New DashboardFileStorage("~/App_Data/Sales"))
                AddHandler salesConfigurator.ConfigureDataConnection, Sub(s, e)
                                                                          Dim databasePath As String = HostingEnvironment.MapPath("~/App_Data/nwind.mdb")
                                                                          If e.ConnectionName = "Northwind connection" Then
                                                                              e.ConnectionParameters = New Access97ConnectionParameters(databasePath, "", "")
                                                                          End If
                                                                      End Sub
                Return New DashboardController(salesConfigurator)
            ElseIf controllerName = "MarketingDashboard" Then
                Dim marketingConfigurator As New DashboardConfigurator()
                marketingConfigurator.SetDashboardStorage(New DashboardFileStorage("~/App_Data/Marketing"))
                AddHandler marketingConfigurator.ConfigureDataConnection, Sub(s, e)
                                                                              Dim connectionString As String = "provider=MSOLAP;" _
                                                                                          & ControlChars.CrLf &
                                                                                          "data source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" _
                                                                                          & ControlChars.CrLf &
                                                                                          "initial catalog=Adventure Works DW Standard Edition;" _
                                                                                          & ControlChars.CrLf &
                                                                                          "cube name=Adventure Works;"
                                                                              If e.ConnectionName = "Adventure Works connection" Then
                                                                                  e.ConnectionParameters = New OlapConnectionParameters(connectionString)
                                                                              End If
                                                                          End Sub
                Return New DashboardController(marketingConfigurator)
            Else
                Return MyBase.CreateController(requestContext, controllerName)
            End If
        End Function

        Public Overrides Sub ReleaseController(ByVal controller As IController)

            Dim dispose_Renamed As IDisposable = TryCast(controller, IDisposable)
            If dispose_Renamed IsNot Nothing Then
                dispose_Renamed.Dispose()
            End If
        End Sub
    End Class
End Namespace