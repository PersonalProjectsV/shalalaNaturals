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
    public partial class BUY : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fillPage();
            /*
            var repo = new ProductRepo();
            List<ProductModel> products = repo.GetAllProducts();

            if (products != null)
            {
                foreach (ProductModel product in products)
                {
                    Panel productPanel = new Panel();
                    ImageButton imageButton = new ImageButton
                    {
                        ImageUrl = "~/Images/Products/" + product.Image,
                        CssClass = "productImage",
                        PostBackUrl = string.Format("~/Pages/Product.aspx?id={0}", product.ID)
                    };
                    Label lblName = new Label
                    {
                        Text = product.Name,
                        CssClass = "productName"
                    };
                    Label lblPrice = new Label
                    {
                        Text = "£ " + product.Price,
                        CssClass = "productPrice"
                    };

                    productPanel.CssClass = "col-md-3";
                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal { Text = "<br/>" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br/>" });
                    productPanel.Controls.Add(lblPrice);

                    //Add dynamic controls to static control
                    pnlProducts.Controls.Add(productPanel);
                }
            }
            else
                pnlProducts.Controls.Add(new Literal { Text = "No products found!" });

            */

        }

        private void fillPage()
        {
            ProductController productController = new ProductController();
            List<PRODUCT> product = productController.GetAllProducts();
            if (product != null)
            {

                foreach (PRODUCT productt in product)
                {
                    Panel productPanel = new Panel();
                    productPanel.CssClass = "cssC";
                    ImageButton imageButton = new ImageButton();
                    Label lblN = new Label();
                    Label lblP = new Label();

                    imageButton.ImageUrl = "~/Images/Products/" + productt.Image;
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/Pages/Product.aspx?id=" + productt.Id;

                    lblN.Text = productt.Name;
                    lblN.CssClass = "productName";
                    lblP.Text = "R " + productt.Price;
                    lblP.CssClass = "productPrice";

                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblN);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblP);

                    pnlProducts.Controls.Add(productPanel);
                }

            }
            else
            {
                pnlProducts.Controls.Add(new Literal { Text = "no products fount" });
            }

        }
    }
}