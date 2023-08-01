using shalalaNaturals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shalalaNaturals.Controllers
{
    public class pTypeController : Controller
    {
        // GET: pType
        public ActionResult Index()
        {
            return View();
        }
        public string InsertProduct(ProductType product)
        {
            try
            {
                shalalaModel gr = new shalalaModel();
                gr.ProductTypes.Add(product);
                gr.SaveChanges();

                return product.Name + "was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error" + e;
            }
        }
        public string UpdateProduct(int id, ProductType product)
        {
            try
            {
                shalalaModel gr = new shalalaModel();
                ProductType p = gr.ProductTypes.Find(id);

                p.Name = product.Name;

                gr.SaveChanges();
                return product.Name + "was successfully updated";

            }
            catch (Exception e)
            {
                return "Error" + e;
            }
        }
        public string DeleteProduct(int id)
        {
            try
            {
                shalalaModel gr = new shalalaModel();
                ProductType p = gr.ProductTypes.Find(id);

                gr.ProductTypes.Attach(p);
                gr.ProductTypes.Remove(p);
                gr.SaveChanges();

                return p.Name + "was successfully removed";
            }
            catch (Exception e)
            {
                return "Error" + e;
            }
        }
    }
}