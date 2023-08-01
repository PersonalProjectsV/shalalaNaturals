using shalalaNaturals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shalalaNaturals.Controllers
{
    public class UserInformationController : Controller
    {
        // GET: UserInformation
        public UserInformation GetUserinformation(string guId)
        {
            shalalaModel db = new shalalaModel();
            UserInformation info = (from x in db.UserInformations
                                    where x.GUID == guId
                                    select x).FirstOrDefault();
            return info;
        }
        public void INsertUserInformation(UserInformation info)
        {
            shalalaModel db = new shalalaModel();
            db.UserInformations.Add(info);
            db.SaveChanges();
        }
    }
}