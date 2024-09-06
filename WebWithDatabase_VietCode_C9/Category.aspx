<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultMasterPage.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="WebLayout_C7_.Category1" %>

<%@ Register Src="~/UserControls/ucProductListByCategory.ascx" TagPrefix="uc1" TagName="ucProductListByCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolderContent" runat="server">
    <uc1:ucProductListByCategory runat="server" id="ucProductListByCategory" />
</asp:Content>
