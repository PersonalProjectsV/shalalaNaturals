using Microsoft.AspNet.Identity;
using shalalaNaturals.Controllers;
using shalalaNaturals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shalalaNaturals.Pages
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Check if user is logged in
            string userId = User.Identity.GetUserId();

            //Display all items in user's cart.
            GetPurchasesInCart(userId);
        }

        protected void Delete_Item(object sender, EventArgs e)
        {
            LinkButton selectedLink = (LinkButton)sender;
            string link = selectedLink.ID.Replace("del", "");
            int cartId = Convert.ToInt32(link);

            CartController repo = new CartController();
            repo.DeleteProduct(cartId);

            Response.Redirect("~/Pages/ShoppingCart.aspx");
        }

        private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get ID of product that has had its quantity dropdownlist changed.
            DropDownList selectedList = (DropDownList)sender;
            int cartId = Convert.ToInt32(selectedList.ID);
            int quantity = Convert.ToInt32(selectedList.SelectedValue);

            //Update purchase with new quantity and refresh page
            CartController repo = new CartController();
            repo.UpdateQuantity(cartId, quantity);
            Response.Redirect("~/Pages/ShoppingCart.aspx");
        }

        private void GetPurchasesInCart(string userId)
        {
            CartController model = new CartController();
            double subTotal = 0;

            //Get all purchases for current user and display in table
            List<CART> purchaseList = model.GetOrdersInCart(userId);
            CreateShopTable(purchaseList, out subTotal);

            //Add totals to webpage
            double vat = subTotal * 0.21;
            double totalAmount = subTotal + 15 + vat;

            litTotal.Text = "R " + subTotal;
            litVat.Text = "R " + vat;
            litTotalAmount.Text = "R " + totalAmount;

            //Add paypal button to checkout
            //string paypal = GeneratePaypalButton(subTotal);
            //litPaypal.Text = paypal;
        }

        private void CreateShopTable(IEnumerable<CART> carts, out double subTotal)
        {
            subTotal = new double();
            ProductController repo = new ProductController();
            if (carts.Count() <= 0) {
                containerCL.Visible = false;
                nothing.Text = "Your cart is empty";
                nothing.Visible = true;
            }
            
            foreach (CART cart in carts)
            {
                // Create HTML elements and fill values with database data
                PRODUCT product = repo.GetPRODUCT(cart.ProductID);

                ImageButton btnImage = new ImageButton
                {
                    ImageUrl = string.Format("~/Images/Products/{0}", product.Image),
                    PostBackUrl = string.Format("~/Pages/Product.aspx?id={0}", product.Id)
                };
                btnImage.CssClass = "productImage";

                LinkButton lnkDelete = new LinkButton
                {
                    PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?productId={0}", cart.Id),
                    Text = "Delete Item",
                    ID = "del" + cart.Id,
                };

                lnkDelete.Click += Delete_Item;

                // Fill amount list with numbers 1-20
                int[] amount = Enumerable.Range(1, 20).ToArray();
                DropDownList ddlAmount = new DropDownList
                {
                    DataSource = amount,
                    AppendDataBoundItems = true,
                    AutoPostBack = true,
                    ID = cart.Id.ToString()
                };
                ddlAmount.DataBind();
                ddlAmount.SelectedValue = cart.Amount.ToString();
                ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

                // Create table to hold shopping cart details
                Table table = new Table { CssClass = "CartTable" };
                TableRow row1 = new TableRow();
                TableRow row2 = new TableRow();

                TableCell cell1_1 = new TableCell { RowSpan = 2, Width = 50 };
                TableCell cell1_2 = new TableCell
                {
                    Text = string.Format("<h4>{0}</h4><br />{1}<br/>In Stock",
                    product.Name, "Item No:" + product.Id),
                    HorizontalAlign = HorizontalAlign.Left,
                    Width = 350,
                };
                TableCell cell1_3 = new TableCell { Text = "Unit Price<hr/>" };
                TableCell cell1_4 = new TableCell { Text = "Quantity<hr/>" };
                TableCell cell1_5 = new TableCell { Text = "Item Total<hr/>" };
                TableCell cell1_6 = new TableCell();

                TableCell cell2_1 = new TableCell();
                TableCell cell2_2 = new TableCell { Text = "R " + product.Price };
                TableCell cell2_3 = new TableCell();
                TableCell cell2_4 = new TableCell { Text = "R " + Math.Round((cart.Amount * Convert.ToDouble(product.Price)), 2) };
                TableCell cell2_5 = new TableCell();

                // Set custom controls
                cell1_1.Controls.Add(btnImage);
                cell1_6.Controls.Add(lnkDelete);
                cell2_3.Controls.Add(ddlAmount);

                // Add rows & cells to table
                row1.Cells.Add(cell1_1);
                row1.Cells.Add(cell1_2);
                row1.Cells.Add(cell1_3);
                row1.Cells.Add(cell1_4);
                row1.Cells.Add(cell1_5);
                row1.Cells.Add(cell1_6);

                row2.Cells.Add(cell2_1);
                row2.Cells.Add(cell2_2);
                row2.Cells.Add(cell2_3);
                row2.Cells.Add(cell2_4);
                row2.Cells.Add(cell2_5);
                table.Rows.Add(row1);
                table.Rows.Add(row2);
                pnlShoppingCart.Controls.Add(table);

                // Add total of current purchased item to subtotal
                subTotal += (cart.Amount * Convert.ToDouble(product.Price));
            }

            // Add selected objects to Session
            Session[User.Identity.GetUserId()] = carts;
        }

        private string GeneratePaypalButton(double subTotal)
        {
            //Set Paypal parameters
            string paypal = string.Format(
                @"<script async='async' src='https://www.paypalobjects.com/js/external/paypal-button.min.js?merchant=garageseller@gmail.com'
                data-button='buynow'
                data-name='Garage Purchases'
                data-quantity=1
                data-amount='{0}'
                data-tax='{1}'
                data-shipping='15'
                data-callback='http://localhost:50992/Pages/Success.aspx'
                data-sendback='http://localhost:50992/Pages/Success.aspx'
                data-env='sandbox'>
             </script>", subTotal, (subTotal * 0.21));

            return paypal;
        }
    }
}