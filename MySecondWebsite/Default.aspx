<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MySecondWebsite._Default" %>


<%@ Register Src="~/UserControl/Default.ascx" TagPrefix="uc" TagName="Default"%>  

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <uc:Default ID="DefaultPage" runat="server" /> 

    <%-- JS SCRIPTS --%>
    <script src="Scripts/Default.js"></script>

    <%-- CSS SCRIPTS --%>
    <link href="Content/Default.css" rel="stylesheet" />
</asp:Content>
