<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucProductDetails.ascx.cs" Inherits="WebLayout_C7_.UserControls.ucProductDetails" %>
<asp:FormView ID="FormView1" runat="server" DataKeyNames="id" DataSourceID="ProductDetailsEntityDataSource">
    <EditItemTemplate>
        id:
        <asp:Label ID="idLabel1" runat="server" Text='<%# Eval("id") %>' />
        <br />
        Name:
        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
        <br />
        FilePath:
        <asp:TextBox ID="FilePathTextBox" runat="server" Text='<%# Bind("FilePath") %>' />
        <br />
        Price:
        <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
        <br />
        Description:
        <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />
        <br />
        Category_id:
        <asp:TextBox ID="Category_idTextBox" runat="server" Text='<%# Bind("Category_id") %>' />
        <br />
        Category:
        <asp:TextBox ID="CategoryTextBox" runat="server" Text='<%# Bind("Category") %>' />
        <br />
        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </EditItemTemplate>
    <InsertItemTemplate>
        id:
        <asp:TextBox ID="idTextBox" runat="server" Text='<%# Bind("id") %>' />
        <br />
        Name:
        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
        <br />
        FilePath:
        <asp:TextBox ID="FilePathTextBox" runat="server" Text='<%# Bind("FilePath") %>' />
        <br />
        Price:
        <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
        <br />
        Description:
        <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />
        <br />
        Category_id:
        <asp:TextBox ID="Category_idTextBox" runat="server" Text='<%# Bind("Category_id") %>' />
        <br />
        Category:
        <asp:TextBox ID="CategoryTextBox" runat="server" Text='<%# Bind("Category") %>' />
        <br />
        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </InsertItemTemplate>
    <ItemTemplate>
        <div class="product_detail_box">
            <div class ="product_image"> <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("FilePath", "~/images/products/{0}") %>' />
        </div>
            <div>
        <br />
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("Category.Name") %>'></asp:Label>&nbsp;
<asp:Label ID="Label1" runat="server" CssClass="product_name" Text='<%# Eval("Name") %>'></asp:Label><br />
        <asp:Label ID="Label2" runat="server" CssClass="product_price" Text='<%# Eval("Price") %>'></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Description") %>'></asp:Label><br />
 </div></div>
            </ItemTemplate>
</asp:FormView>
<asp:EntityDataSource ID="ProductDetailsEntityDataSource" runat="server" ConnectionString="name=MyShopEntities2" DefaultContainerName="MyShopEntities2" EnableFlattening="False" EntitySetName="Products" EntityTypeFilter="Product" Include="Category" Where ="it.Id = @Id " >
<WhereParameters>
    <asp:QueryStringParameter Name ="Id" QueryStringField="id" Type="Int32" />
</WhereParameters>
</asp:EntityDataSource>

