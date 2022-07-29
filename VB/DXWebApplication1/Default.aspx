﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="DXWebApplication1.Default" %>

<%@ Register Assembly="DevExpress.Dashboard.v18.2.Web.WebForms, Version=18.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <script src="Scripts/slideshow.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxDashboard ID="ASPxDashboard1" ClientInstanceName="Dashboard" runat="server" WorkingMode="Viewer">
                <ClientSideEvents BeforeRender="onBeforeRender" DashboardTitleToolbarUpdated="onDashboardTitleToolbarUpdated" />
            </dx:ASPxDashboard>
        </div>
    </form>
</body>
</html>
