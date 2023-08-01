<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="shalalaNaturals.Pages.Management.Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .everything {
            color:#9dc15b;
        }
        a{color:#9dc15b;}
    </style>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder3" runat="server" >MANAGEMENT</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="everything">
     <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button" PostBackUrl="~/Pages/Management/ManageProducts.aspx">Add new Product</asp:LinkButton>
    <p style="clear: both"></p>
    <asp:GridView ID="grdProducts" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="sdsProduct" Width="100%" AllowPaging="True" AllowSorting="True" OnRowEditing="grdProducts_RowEditing">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Typeid" HeaderText="Typeid" SortExpression="Typeid" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="sdsProduct" runat="server" ConnectionString="<%$ ConnectionStrings:shalalaModel %>" DeleteCommand="DELETE FROM [PRODUCT] WHERE [Id] = @Id" InsertCommand="INSERT INTO [PRODUCT] ([Typeid], [Name], [Price], [Description], [Image]) VALUES (@Typeid, @Name, @Price, @Description, @Image)" SelectCommand="SELECT * FROM [PRODUCT]" UpdateCommand="UPDATE [PRODUCT] SET [Typeid] = @Typeid, [Name] = @Name, [Price] = @Price, [Description] = @Description, [Image] = @Image WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Typeid" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Image" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Typeid" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Image" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="button" PostBackUrl="~/">Add new Type</asp:LinkButton>
    <p style="clear: both"></p>
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="sdsProductTypes" Width="50%" AllowPaging="True" AllowSorting="True" DataKeyNames="ID">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="sdsProductTypes" runat="server" ConnectionString="<%$ ConnectionStrings:shalalaModel %>" SelectCommand="SELECT * FROM [ProductTypes]">
    </asp:SqlDataSource>
        </div>
</asp:Content>
