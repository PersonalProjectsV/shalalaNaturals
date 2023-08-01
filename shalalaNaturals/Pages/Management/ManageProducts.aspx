<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="shalalaNaturals.Pages.Management.ManageProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .everything {
            color:#9dc15b;
        }
        a{color:#9dc15b;}
    </style>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder3" runat="server" >MANAGE PRODUCTS</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="everything">
    <p>Name:</p>
    <p>
        <asp:TextBox ID="txtName" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>Type:</p>
    <p>
        <asp:DropDownList ID="ddlType" CssClass="inputs" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:shalalaModel %>" SelectCommand="SELECT * FROM [ProductTypes]"></asp:SqlDataSource>
    </p>
    <p>
        Price:</p>
    <p>
        <asp:TextBox ID="txtPrice" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        Image:</p>
    <p>
        <asp:DropDownList ID="ddlImage" runat="server" CssClass="inputs" Width="270">
        </asp:DropDownList>
    </p>
        <asp:FileUpload ID="file" runat="server" />
    <p>
        Description:</p>
    <p>
        <asp:TextBox ID="txtDescription" runat="server" Height="74px" TextMode="MultiLine" CssClass="inputs" Width="240px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="button" />
    </p>
    <p>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>
        </div>
</asp:Content>
