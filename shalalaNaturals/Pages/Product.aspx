<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="shalalaNaturals.Pages.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .detailsImage {
            width:500px;
            height:500px;
            margin-right:20px;
        }
        .forHide2 {
            display: none;
        }
        .detailsDescription {
            width:500px;
            font-style:italic;

        }
        .detailsPrice {
            font-size:26px;
            font-style:bold;
        }
        .button {
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
        .detailsImage1 {
            width:500px;
            height:500px;
        }
        .detailsDescription1 {
            width:500px;
            font-style:italic;

        }
        .detailsPrice1 {
            font-size:26px;
            font-style:bold;
        }
        .button1{
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
        .everything{color:#9dc15b;}
        h2{color:#9dc15b}
            @media only screen and (max-width : 675px) {
                /* Styes here */
                .detailsImage {
                    width: 300px;
                    height: 300px;
                }
                        .detailsDescription {
            width:300px;
            font-style:italic;

        }
                                .detailsPrice {
            font-size:18px;
            font-style:bold;
        }
                                        .button {
            width:100px;
            font-size:12px;

        }
                                        .everything{
                        font-size: 18px;
                    }
                                        h2{font-size:24px;}
            }
            @media only screen and (max-width : 550px) {
                /* Styes here */
                .detailsImage {
                    width: 200px;
                    height: 200px;
                }

                .detailsDescription {
                    width: 200px;
                    font-style: italic;
                }

                .detailsPrice {
                    font-size: 12px;
                    font-style: bold;
                }

                .button {
                    width: 60px;
                    font-size: 8px;
                }
                .everything{
                        font-size: 12px;
                    }
                h2{font-size:15px;}
            }

                @media only screen and (max-width : 385px) {
                    /* Styes here */
                    .detailsImage {
                        width: 150px;
                        height: 150px;
                    }

                    .detailsDescription {
                        width: 150px;
                        font-style: italic;
                    }

                    .detailsPrice {
                        font-size: 8px;
                        font-style: bold;
                    }

                    .button {
                        width: 55px;
                        font-size: 8px;
                    }
                    .everything{
                        font-size: 8px;
                    }
                    h2{font-size:12px;}
                }
                @media only screen and (max-width : 365px) {
                    /* Styes here */
                    .detailsImage {
                        width: 120px;
                        height: 120px;
                    }

                    .detailsDescription {
                        width: 120px;
                        font-style: italic;
                    }

                    .detailsPrice {
                        font-size: 8px;
                        font-style: bold;
                    }

                    .button {
                        width: 50px;
                        font-size: 8px;
                    }
                    .everything{
                        font-size: 8px;
                    }
                    h2{font-size:10px;}
                }
                		@media only screen and (max-width : 600px) {
   /* Styes here */
                            .forHide2 {
                                display:inline-block;
                            }
                            .forHide {
                                display:none;
                            }
                            .forHide2 img {
                                width: 100%;
                                height: auto;                                
                            }
                            .content {
                                padding-left:30px;
                            }
        .detailsDescription1 {
            width:200%;
            font-style:italic;

        }
        .detailsPrice1 {
            font-size:200%;
            font-style:bold;
        }
        .button1{
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
	        }
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="everything">
     <table class="forHide">
        <tr>
            <td rowspan="4" style="width: 400px">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" />
            </td>
            <td style="width: 400px;">
                <h2>
                    <asp:Label ID="lblTitle" runat="server"></asp:Label></h2>
                <hr />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:Label>
            </td>
            <td style="margin-left: 10px">
                <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label><br />
                Quantity:<asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br />
                <asp:Button ID="btnAdd" runat="server" CssClass="button" OnClick="btnAdd_Click" Text="Add Product" />
                <br />
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Product No:
                <br />
                <asp:Label ID="lblItemNr" runat="server" Style="font-style: italic"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;<asp:Label ID="lblAvailable" runat="server" CssClass="productPrice">Available!</asp:Label>
            </td>
        </tr>
    </table>
           <div class="forHide2">
           <asp:Image ID="imgProduct1" runat="server" CssClass="detailsImage1" />
               <div class="content">
           <h2><asp:Label ID="lblTitle1" runat="server"></asp:Label></h2>
           <asp:Label ID="lblDescription1" runat="server" CssClass="detailsDescription1"></asp:Label>
               <asp:Label ID="lblPrice1" runat="server" CssClass="detailsPrice1"></asp:Label><br />
               Quantity:<asp:DropDownList ID="ddlAmount1" runat="server"></asp:DropDownList><br />
               <asp:Button ID="btnAdd1" runat="server" CssClass="button1" OnClick="btnAdd_Click" Text="Add Product" /><br />
               <asp:Label ID="lblResult1" runat="server"></asp:Label>
               <asp:Label ID="lblAvailable1" runat="server" CssClass="productPrice1">Available!</asp:Label>
               </div>
               </div>

       </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
