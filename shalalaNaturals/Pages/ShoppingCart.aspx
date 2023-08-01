<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="shalalaNaturals.Pages.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
                .productImage {
            width:500px;
            height:500px;
        }
        .CartTable {
            text-align:center;
            border: 15px solid #9dc15b;
            margin-bottom:10px;
            width:100%;
            padding:10px;
        }
            .CartTable input {
                width:65px;
                height:65px;
            }
            .CartTable h4 {
                padding:0;
                margin:0;  
            }
            .CartTable tr td select {
                width:100px;
            }
            .everything{color:#9dc15b;}
        h2{color:#9dc15b}
        .button, table a {
            align-items:center;
            margin:10px;
            color:#9dc15b;
            border:0;
            border-radius:4px;
            -moz-border-radius:4px;
            -webkit-border-radius:4px;
            clear:both;
            background:linear-gradient(to bottom,darkgreen,green);
        }

    </style>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder3" runat="server" >CART</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="everything">
    <asp:Panel ID="pnlShoppingCart" ForeColor="#9dc15b"  runat="server">
    </asp:Panel>
          <asp:Panel runat="server" ForeColor="#9dc15b" ID="containerCL">
    <table>
        <tr>
            <td>
                <b>Total: </b>
            </td>
            <td>
                <asp:Literal ID="litTotal" runat="server" Text=""></asp:Literal>
            </td>
        </tr>

        <tr>
            <td>
                <b>Vat: </b>
            </td>
            <td>
                <asp:Literal ID="litVat" runat="server" Text="" />
            </td>
        </tr>
        <tr>
            <td>
                <b>Shipping: </b>
            </td>
            <td>£ 15
            </td>
        </tr>

        <tr>
            <td>
                <b>Total Amount: </b>
            </td>
            <td>
                <asp:Literal ID="litTotalAmount" runat="server" Text="" />
            </td>
        </tr>

        <tr>
            <td>
                <br />
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Pages/BUY.aspx">Continue Shopping</asp:LinkButton>
                &nbsp;&nbsp; or
                    <asp:Button ID="btnCheckout" runat="server" Text="Check Out" CssClass="button" Width="250px" PostBackUrl="~/Pages/SUCCESS.aspx" />

                <br />

                <asp:LinkButton ID="litPaypal" Text="" runat="server" />
            </td>
        </tr>
    </table>
          </asp:Panel>
        </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="mail" HeaderText="mail" SortExpression="mail" />
            <asp:BoundField DataField="FirtsName" HeaderText="FirtsName" SortExpression="FirtsName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
            <asp:BoundField DataField="street1" HeaderText="street1" SortExpression="street1" />
            <asp:BoundField DataField="street2" HeaderText="street2" SortExpression="street2" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="Province" HeaderText="Province" SortExpression="Province" />
            <asp:BoundField DataField="zipCode" HeaderText="zipCode" SortExpression="zipCode" />
            <asp:BoundField DataField="GUID" HeaderText="GUID" SortExpression="GUID" />
        </Columns>
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:shalalaModel %>" SelectCommand="SELECT * FROM [UserInformation]"></asp:SqlDataSource>
<asp:SqlDataSource ID="shalalaModel" runat="server"></asp:SqlDataSource>
    <asp:Label runat="server" Visible="false" ForeColor="#9dc15b" ID="nothing" CssClass="words"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
