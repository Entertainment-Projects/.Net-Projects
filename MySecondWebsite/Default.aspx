<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MySecondWebsite._Default" %>


<%@ Register Src="~/UserControl/Default.ascx" TagPrefix="uc" TagName="Default"%>  

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Default.css" rel="stylesheet" />
    <uc:Default ID="DefaultPage" runat="server" /> 
</asp:Content>
