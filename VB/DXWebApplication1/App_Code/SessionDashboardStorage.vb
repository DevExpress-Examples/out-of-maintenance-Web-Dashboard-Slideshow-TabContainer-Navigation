Imports DevExpress.DashboardWeb
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.SessionState
Imports System.Xml.Linq
Public Class SessionDashboardStorage
	Inherits DashboardStorageBase

	Private Const DashboardStorageKey As String = "DashboardStorage"
'INSTANT VB NOTE: The field instance was renamed since Visual Basic does not allow fields to have the same name as other class members:
	Private Shared instance_Renamed As SessionDashboardStorage = Nothing
	Public Shared ReadOnly Property Instance() As SessionDashboardStorage
		Get
			If instance_Renamed Is Nothing Then
				instance_Renamed = New SessionDashboardStorage()
			End If
			Return instance_Renamed
		End Get
	End Property
	Private ReadOnly Property Storage() As Dictionary(Of String, XDocument)
		Get
			Dim session As HttpSessionState = HttpContext.Current.Session
			If session IsNot Nothing Then
'INSTANT VB NOTE: The local variable storage was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
				Dim storage_Renamed As Dictionary(Of String, XDocument) = TryCast(session(DashboardStorageKey), Dictionary(Of String, XDocument))
				If storage_Renamed Is Nothing Then
					storage_Renamed = New Dictionary(Of String, XDocument)()
					session(DashboardStorageKey) = storage_Renamed
					Return storage_Renamed
				End If
				Return storage_Renamed
			End If
			Throw New Exception()
		End Get
	End Property
	Protected Sub New()
		MyBase.New()
		RegisterDefaultDashboard("dashboard1")
	End Sub
	Protected Overrides Function GetAvailableDashboardsID() As IEnumerable(Of String)
		Return Storage.Keys
	End Function
	Protected Overrides Function LoadDashboard(ByVal dashboardID As String) As XDocument
		Dim document As XDocument = Storage(dashboardID)
		Return document
	End Function
	Protected Overrides Sub SaveDashboard(ByVal dashboardID As String, ByVal dashboard As XDocument, ByVal createNew As Boolean)
		If createNew Xor Storage.ContainsKey(dashboardID) Then
			Storage(dashboardID) = dashboard
		End If
	End Sub
	Public Sub RegisterDashboard(ByVal dashboardID As String, ByVal dashboard As XDocument)
		SaveDashboard(dashboardID, dashboard, True)
	End Sub
	Private Sub RegisterDefaultDashboard(ByVal dashboardId As String)
		Dim dashboardLocalPath As String = HttpContext.Current.Server.MapPath(String.Format("~/App_Data/Dashboards/{0}.xml", dashboardId))
		RegisterDashboard(dashboardId, XDocument.Load(dashboardLocalPath))
	End Sub
End Class