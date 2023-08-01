using shalalaNaturals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shalalaNaturals.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public string InsertProduct(PRODUCT product)
        {
            try
            {
                shalalaModel gr = new shalalaModel();
                gr.PRODUCTs.Add(product);
                gr.SaveChanges();

                return product.Name + "was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error" + e;
            }
        }
        public string UpdateProduct(int id, PRODUCT product)
        {
            try
            {
                shalalaModel gr = new shalalaModel();
                PRODUCT p = gr.PRODUCTs.Find(id);

                p.Name = product.Name;
                p.Price = product.Price;
                p.TypeId = product.TypeId;
                p.Description = product.Description;
                p.Image = product.Image;

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
                PRODUCT p = gr.PRODUCTs.Find(id);

                gr.PRODUCTs.Attach(p);
                gr.PRODUCTs.Remove(p);
                gr.SaveChanges();

                return p.Name + "was successfully removed";
            }
            catch (Exception e)
            {
                return "Error" + e;
            }
        }

        public PRODUCT GetPRODUCT(int id)
        {
            try
            {
                using (shalalaModel db = new shalalaModel())
                {
                    PRODUCT product = db.PRODUCTs.Find(id);
                    return product;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<PRODUCT> GetAllProducts()
        {
            try
            {
                shalalaModel db = new shalalaModel();

                List<PRODUCT> products = (from x in db.PRODUCTs
                                          select x).ToList();

                return products;

            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<PRODUCT> GetProductsByType(int id)
        {
            try
            {
                using (shalalaModel db = new shalalaModel())
                {
                    List<PRODUCT> products = (from x in db.PRODUCTs
                                              where x.TypeId == id
                                              select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}