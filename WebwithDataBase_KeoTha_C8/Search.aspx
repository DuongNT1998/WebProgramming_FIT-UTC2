<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultMasterPage.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WebLayout_C7_.Search" %>

<%@ Register Src="~/UserControls/ucSearchProduct.ascx" TagPrefix="uc1" TagName="ucSearchProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolderContent" runat="server">
    <uc1:ucSearchProduct runat="server" id="ucSearchProduct" />
</asp:Content>
