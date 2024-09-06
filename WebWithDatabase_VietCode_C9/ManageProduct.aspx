<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultMasterPage.Master" AutoEventWireup="true" CodeBehind="ManageProduct.aspx.cs" Inherits="WebLayout_C7_.ManageProduct" %>

<%@ Register Src="~/UserControls/ucManageProduct.ascx" TagPrefix="uc1" TagName="ucManageProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolderContent" runat="server">
    <uc1:ucManageProduct runat="server" id="ucManageProduct" />
</asp:Content>
