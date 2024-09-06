<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucManageProduct.ascx.cs" Inherits="WebLayout_C7_.UserControls.ucManageProduct" %>
<table style="width:100%;">
    <tr>
        <td>Product name:</td>
        <td><asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Price</td>
        <td>
            <asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Category</td>
        <td><asp:DropDownList ID="DropDownListCategory" runat="server"></asp:DropDownList></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
    <td>Description</td>
    <td>
        <asp:TextBox ID="TextBoxDescription" TextMode="MultiLine" runat="server"></asp:TextBox></td>
       
    <td>&nbsp;</td>
</tr>
    <tr>
     <td>Picture</td>
     <td>
         <asp:FileUpload ID="FileUploadPicture" runat="server" /></td>
     <td>&nbsp;</td>
 </tr>

    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="ButtonAddNew" runat="server" Text="Add new" OnClick="ButtonAddNew_Click" /></td>
    </tr>
</table>

<asp:GridView ID="GridViewProducts" AllowPaging="true" PageSize="5"  AutoGenerateColumns="false" runat="server" OnRowCommand="GridViewProducts_RowCommand" OnPageIndexChanging="GridViewProducts_PageIndexChanging" DataKeyNames="id">
<Columns>
    <asp:TemplateField HeaderText="No.">
        <ItemTemplate>
            <%# Container.DataItemIndex+1 %>
        </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Picture">
        <ItemTemplate>
            <asp:Image runat="server" ID="imageProduct" ImageUrl='<%# "~/images/Products/" + Eval("FilePath") %>' Width="100px" Height="100px" />
        </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Name">
        <ItemTemplate>
            <asp:HyperLink ID="HyperLink1" Text='<%# Eval("Name")%>' Target="_blank" runat="server" NavigateUrl='<%# "~/Details.aspx?id="+Eval("id") %>'></asp:HyperLink>
        </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField>
        <ItemTemplate>
            <asp:Button runat="server" OnClientClick="return confirm('Do you really want to delete this product?');" ID="DeleteButton" Text="Delete" CommandName="Xoa" CommandArgument='<%# Eval("id") %>'/>
        </ItemTemplate>
    </asp:TemplateField>
</Columns>
</asp:GridView>



