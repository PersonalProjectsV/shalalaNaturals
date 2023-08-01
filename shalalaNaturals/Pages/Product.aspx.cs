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
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string clientID = Context.User.Identity.GetUserId();
                if (clientID != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    int amount = Convert.ToInt32(ddlAmount.SelectedValue);



                    CART cart = new CART
                    {
                        Amount = amount,
                        ClientID = clientID,
                        DatePurchased = DateTime.Now.ToUniversalTime(),
                        IsInCart = true,
                        ProductID = id
                    };

                    CartController repo = new CartController();
                    lblResult.Text = repo.InsertProduct(cart);
                }
                else
                {
                    lblResult.Text = "Please log in to order items";
                }
            }
        }


        private void FillPage()
        {
            //Get selected product data
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ProductController productRepo = new ProductController();
                PRODUCT product = productRepo.GetPRODUCT(id);

                //Fill page with data
                lblTitle.Text = product.Name;
                lblDescription.Text = product.Description;
                lblPrice.Text = "Price per unit:<br/>R " + product.Price;
                imgProduct.ImageUrl = "~/Images/Products/" + product.Image;
                imgProduct1.ImageUrl = "~/Images/Products/" + product.Image;
                lblTitle1.Text = product.Name;
                lblDescription1.Text = product.Description;
                lblPrice1.Text = "Price per unit:<br/>R " + product.Price;

                lblItemNr.Text = product.Id.ToString();

                //Fill amount list with numbers 1-20
                int[] amount = Enumerable.Range(1, 20).ToArray();
                ddlAmount.DataSource = amount;
                ddlAmount.AppendDataBoundItems = true;
                ddlAmount.DataBind();
                ddlAmount1.DataSource = amount;
                ddlAmount1.AppendDataBoundItems = true;
                ddlAmount1.DataBind();
            }
        }
    }
}