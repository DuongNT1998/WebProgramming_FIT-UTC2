<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl_Login.ascx.cs" Inherits="WebControl_C6_.WebUserControl_Login" %>
<p>
    Username:
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    <br />
    Password:
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Button ID="btnLogIn" runat="server" Text="Log in" />
</p>

