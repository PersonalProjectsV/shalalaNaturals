using shalalaNaturals.Controllers;
using shalalaNaturals.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shalalaNaturals.Pages.Management
{
    public partial class ManageProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                

                //Check if product is being updated
                if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    FillForm(id);
                }
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ProductController productC = new ProductController();
            PRODUCT product = CreateProduct();

            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                lblResult.Text = productC.UpdateProduct(id, product);
            }
            else
            {
                lblResult.Text = productC.InsertProduct(product);
            }
        }

        private void FillForm(int id)
        {
            try
            {
                ProductController productRepo = new ProductController();
                PRODUCT product = productRepo.GetPRODUCT(id);
                if (product != null)
                {
                    txtDescription.Text = product.Description;
                    txtName.Text = product.Name;
                    txtPrice.Text = product.Price.ToString();

                    ddlImage.SelectedValue = product.Image;
                    ddlType.SelectedValue = product.TypeId.ToString();
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.ToString();
            }
        }


        private void GetImages()
        {
            try
            {
                // Get all filepaths
                string[] images = Directory.GetFiles(Server.MapPath("~/Images/Products/"));

                // Get all filenames and add them to an arraylist
                ArrayList imageList = new ArrayList();
                foreach (string image in images)
                {
                    string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }

                // Set the arrayList as the dropdownview's datasource and refresh
                ddlImage.DataSource = imageList;
                ddlImage.AppendDataBoundItems = true;
                ddlImage.DataBind();
            }
            catch (Exception e)
            {
                lblResult.Text = e.ToString();
            }
        }

        private PRODUCT CreateProduct()
        {
            PRODUCT product = new PRODUCT();


            product.Name = txtName.Text;
            product.Price = Convert.ToInt32(txtPrice.Text);
            product.TypeId = Convert.ToInt32(ddlType.SelectedValue);
            product.Description = txtDescription.Text;

            HttpPostedFile f = file.PostedFile;
            string pImage = Server.MapPath("~/Images/Products/") + f.FileName;
            product.Image = f.FileName;
            f.SaveAs(pImage);


            return product;
        }
    }
}