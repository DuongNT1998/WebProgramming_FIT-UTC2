<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebControl_C6_.Default" %>

<%@ Register src="WebUserControl_Login.ascx" tagname="WebUserControl_Login" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="WebUserControl_Login">
    <form id="form1" runat="server">
        <div>
            <input id="txtName" type="text" runat="server" /><input id="btnSubmit" runat="server" type="button" value="Submit" onserverclick="Button1_ServerClick" />
        </div>
        <uc1:WebUserControl_Login ID="WebUserControl_Login1" runat="server" />
    </form>
</body>
</html>
