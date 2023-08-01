using Microsoft.AspNet.Identity;
using shalalaNaturals.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace shalalaNaturals
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var user = Context.User.Identity;

            if (user.IsAuthenticated)
            {
                lnkLogin.Visible = false;
                lnkRegister.Visible = false;

                lnkLogout.Visible = true;
                litStatus.Visible = true;


                CartController model = new CartController();
                string userId = HttpContext.Current.User.Identity.GetUserId();
                litStatus.Text = string.Format("{0} ({1})", Context.User.Identity.Name, model.GetAmountOfOrders(userId));


                if (user.Name == "Admin")
                {
                    HyperLink1.Visible = true;
                }
                else
                {
                    HyperLink1.Visible = false;
                }


            }
            else
            {
                HyperLink1.Visible = false;

                lnkLogin.Visible = true;
                lnkRegister.Visible = true;

                lnkLogout.Visible = false;
                litStatus.Visible = false;
            }
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("~/Pages/HOME.aspx");


        }
    }
}