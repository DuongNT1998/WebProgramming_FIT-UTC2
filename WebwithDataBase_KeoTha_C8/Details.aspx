<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultMasterPage.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="WebLayout_C7_.Details" %>

<%@ Register Src="~/UserControls/ucProductDetails.ascx" TagPrefix="uc1" TagName="ucProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolderContent" runat="server">
    <uc1:ucProductDetails runat="server" id="ucProductDetails" />
</asp:Content>
