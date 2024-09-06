<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPNETControl.aspx.cs" Inherits="WebControl_C6_.ASPNETControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 338px;
        }
        .auto-style3 {
            width: 52%;
            height: 118px;
        }
        .auto-style4 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnDangKy" defaultfocus="txtTenDangNhap">
        <div>
            <asp:Panel ID="PanelCopy" runat="server" DefaultButton="btnCopy">
            <%-- <asp:TextBox ID="txtString_1" runat="server" AutoPostBack="True" OnTextChanged="txtString1_TextChanged"></asp:TextBox>--%>
             <asp:TextBox ID="txtString1" runat="server"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="validateString1" runat="server" ControlToValidate="txtString1" ErrorMessage="Textbox này không được rỗng" ValidationGroup="Copy">*</asp:RequiredFieldValidator>
              <asp:Button ID="btnCopy" runat="server" Text="Button" OnClick="btnCopy_Click" ValidationGroup="Copy" />
            <br/>
            <asp:TextBox ID="txtString2" runat="server"></asp:TextBox>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
                </asp:Panel>
        </div>
        <table class="auto-style3">
     <tr>
         <th colspan="2">Form đăng ký thành viên</th>
    
     </tr>
     <tr>
         <td class="auto-style1">Tên đăng nhập</td>
         <td>
             <asp:TextBox ID="txtTenDangNhap" runat="server"  Width="302px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTenDangNhap" ErrorMessage="Tên đăng nhập không được rỗng">*</asp:RequiredFieldValidator>
         </td>
     </tr>
     <tr>
         <td class="auto-style1">Mật khẩu</td>
         <td>
             <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password" Width="301px"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td class="auto-style1">Xác nhận mật khẩu</td>
         <td>
             <asp:TextBox ID="txtXacNhanMatKhau" runat="server" TextMode="Password" Width="301px"></asp:TextBox>
             <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtMatKhau" ControlToValidate="txtXacNhanMatKhau" ErrorMessage="Hai mật khẩu phải giống nhau"></asp:CompareValidator>
         </td>
     </tr>
     <tr>
         <td class="auto-style1">&nbsp;</td>
         <td>&nbsp;</td>
     </tr>
     <tr>
         <td class="auto-style1">Địa chỉ</td>
         <td>
             <asp:TextBox ID="txtDiaChi" runat="server" TextMode="MultiLine"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td class="auto-style1">Email</td>
         <td>
             <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Địa chỉ email không hợp lệ" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
         </td>
     </tr>
     <tr>
         <td class="auto-style1">MSSV</td>
         <td>
             <asp:TextBox ID="txtMssv" runat="server"></asp:TextBox>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtMssv" ErrorMessage="MSSV là 1 chuỗi có 7 chữ số" ValidationExpression="\d[7]"></asp:RegularExpressionValidator>
         </td>
     </tr>
     <tr>
         <td class="auto-style1">Khóa</td>
         <td>
             <asp:TextBox ID="txtKhoa" runat="server"></asp:TextBox>
             <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtKhoa" ErrorMessage="Khóa phải từ 1996 đến 2022" MaximumValue="2022" MinimumValue="1996" Type="Integer"></asp:RangeValidator>
         </td>
     </tr>
     <tr>
         <td class="auto-style1">Chuyên ngành</td>
         <td>
             <asp:DropDownList ID="cmbChuyenNganh" runat="server">
                 <asp:ListItem>Công nghệ phần mềm</asp:ListItem>
                 <asp:ListItem>Hệ thống thông tin</asp:ListItem>
                 <asp:ListItem>Khoa học máy tính</asp:ListItem>
             </asp:DropDownList>
         </td>
     </tr>
     <tr>
         <td class="auto-style4">
             &nbsp;</td>
         <td class="auto-style4">
             <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký" OnClick="btnDangKy_Click" />
         </td>
     </tr>
 </table>
        <asp:PlaceHolder ID="PlaceHolderUserControl" runat="server"></asp:PlaceHolder>
    </form>
   
</body>
</html>
