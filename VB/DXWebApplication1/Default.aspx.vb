Imports DevExpress.DashboardWeb
Imports System


Namespace DXWebApplication1
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxDashboard1.SetDashboardStorage(SessionDashboardStorage.Instance)
			'ASPxDashboard1.SetDashboardStorage(new DashboardFileStorage("~/App_Data/Dashboards")); // Uncomment this line to use the App_Data/Dashboards folder to store dashboards.
		End Sub
	End Class
End Namespace