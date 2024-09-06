<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucManageCategory.ascx.cs" Inherits="WebLayout_C7_.UserControls.ucManageCategory" %>
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ProductListEntityDataSource">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
    </Columns>
</asp:GridView>
<asp:EntityDataSource ID="ProductListEntityDataSource" runat="server" ConnectionString="name=MyShopEntities2" DefaultContainerName="MyShopEntities2" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="Categories" EntityTypeFilter="Category" OnUpdated="ProductListEntityDataSource_Updated" OnDeleted="ProductListEntityDataSource_Updated">
</asp:EntityDataSource>
<asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="CategoryEntityDataSource">
    <Fields>
        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
        <asp:CommandField ShowInsertButton="True" />
    </Fields>
</asp:DetailsView>
<asp:EntityDataSource ID="CategoryEntityDataSource" AutoGenerateWhereClause="true" runat="server" ConnectionString="name=MyShopEntities2" DefaultContainerName="MyShopEntities2" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="Categories" Where="" OnInserted="ProductListEntityDataSource_Updated">
    <WhereParameters>
        <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" />
    </WhereParameters>
</asp:EntityDataSource>

