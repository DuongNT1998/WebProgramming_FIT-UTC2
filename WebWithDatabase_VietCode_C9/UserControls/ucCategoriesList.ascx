<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucCategoriesList.ascx.cs" Inherits="WebLayout_C7_.UserControls.ucCategoriesList" %>
<asp:DataList ID="DataList1" runat="server" DataSourceID="CategoryListEntityDataSource" DataKeyField="id">
    <ItemTemplate>
        <div>

            <asp:HyperLink ID="HyperLink1" runat="server"  Text='<%# Eval("Name") + "("+ Eval("Products.Count")+")" %>' NavigateUrl='<%# "~/Category.aspx?id=" + Eval("id")%>' ></asp:HyperLink>
       
        </div>
       
       
       
    </ItemTemplate>
</asp:DataList>
<asp:EntityDataSource ID="CategoryListEntityDataSource" runat="server" ConnectionString="name=MyShopEntities2" DefaultContainerName="MyShopEntities2" EnableFlattening="False" EntitySetName="Categories" EntityTypeFilter="Category" Include="Products">
</asp:EntityDataSource>

