using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using shalalaNaturals.Controllers;
using shalalaNaturals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shalalaNaturals.Pages.Account
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // Default UserStore constructor uses the default connection string named: DefaultConnection
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();



            // Set ConnectionString to GarageConnectionString
            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["shalalaModel"].ConnectionString;
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            // Create new user and try to store in DB.
            
            IdentityUser user = new IdentityUser { UserName = txtUserName.Text };
            
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    IdentityResult result = manager.Create(user, txtPassword.Text);
                    if (result.Succeeded)
                    {
                        UserInformation info = new UserInformation
                        {
                            mail = txtEmail.Text,
                            FirtsName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            street1 = address1.Text,
                            street2 = address2.Text,
                            City = city.Text,
                            Province = province.SelectedValue,
                            zipCode = int.Parse(zipCode.Text),
                            GUID = user.Id,
                            number = number.Text
                            
                            
                        };

                        UserInformationController model = new UserInformationController();
                        model.INsertUserInformation(info);

                        // Store user in DB
                        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                        var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                        // If succeedeed, log in the new user and set a cookie and redirect to homepage
                        authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                        Response.Redirect("~/Pages/HOME.aspx");
                    }
                    else
                    {
                        litStatusMessage.Text = result.Errors.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    litStatusMessage.Text = ex.ToString();
                }
            }
            else
            {
                litStatusMessage.Text = "Passwords must match!";
            }
        }
    }
}