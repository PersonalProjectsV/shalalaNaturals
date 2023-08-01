<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BUY.aspx.cs" Inherits="shalalaNaturals.Pages.BUY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style>
        #ContentPlaceHolder1_pnlProducts div {
    width:30%;
    margin-left:auto;
    margin-right:auto;
    height: 290px;
    text-align: center;
    margin-bottom:150px;

    

}

.productImage{
    width:290px;
    height:290px;
    vertical-align:central;
    padding:10px;
    

}
            .productImage:hover {
                border: 5px solid #9dc15b;
            }

          .aClass {
              width:100%;
          }
.productName {
    font-family:cursive;
    font-size:21px;
    font-weight:bold;
    vertical-align:central;
    color:#9dc15b;

}
.rowsss{display:-ms-flexbox;display:flex;-ms-flex-wrap:wrap;flex-wrap:wrap;}
            .cssC {
                background-color:		rgb(68, 60, 60);
            }
.productPrice {
    font-size:21px;
    font-family:cursive;
    color:#9dc15b;
    text-align:center;
    vertical-align:central;
    font-weight:bold;
}
            .not {
                background:#1f1f1f url('../../images/mypic6.jpg') no-repeat center; 
            }

@media only screen 
   and (min-width : 200px) {
   /* Styles here */


}
@media only screen 
   and (max-width : 320px) {
   /* Styes here */
                         #ContentPlaceHolder1_pnlProducts div {
    width:100%;
    height: 290px;
    text-align: center;
    margin-bottom:150px;
    
    

}



}
@media only screen 
and (max-width : 600px) {
   /* Styes here */
          .productImage {
             all:unset;
             width: 100%;
             height: auto; 
             max-width:270px;
             max-height:270px;
             margin-bottom:60px;
          }


}
       
@media only screen 
   and (max-width : 768px) {
   /* Styles here */


   }

@media only screen 
   and (min-width : 1200px) {
   /* Styles here */
 
}
@media only screen 
   and (min-width : 1600px) {
   /* Styles here */

}
            @media only screen and (max-width : 960px) {
                /* Styles here */
                #ContentPlaceHolder1_pnlProducts div {
                    width: 50%;
                    height:auto;
                    text-align: center;
                    margin-bottom: 150px;
                }
            }

                @media only screen and (max-width : 615px) {
                    /* Styles here */
                    #ContentPlaceHolder1_pnlProducts div {
                        width: 100%;
                        height:auto;
                        text-align: center;
                        margin-bottom: 150px;
                    }
                }

</style>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder3" runat="server" >BUY</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:rgb(68, 60, 60);">
            <asp:Panel ID="pnlProducts" CssClass="rowsss"  runat="server"></asp:Panel>
        </div>
    <div style="clear: both"></div>
</asp:Content>
