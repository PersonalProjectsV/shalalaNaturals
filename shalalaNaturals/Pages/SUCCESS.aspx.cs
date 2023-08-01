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
    public partial class SUCCESS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<CART> carts = (List<CART>)Session[User.Identity.GetUserId()];

            CartController repo = new CartController();
            repo.MArkOrderAsPaid(carts);

            Session[User.Identity.GetUserId()] = null;
        }
    }
}