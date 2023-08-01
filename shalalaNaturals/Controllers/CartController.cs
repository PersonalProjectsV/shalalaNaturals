using shalalaNaturals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shalalaNaturals.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public string InsertProduct(CART product)
        {
            try
            {
                shalalaModel gr = new shalalaModel();
                gr.CARTs.Add(product);
                gr.SaveChanges();

                return product.DatePurchased + "was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error" + e;
            }
        }
        public string UpdateProduct(int id, CART product)
        {
            try
            {
                shalalaModel gr = new shalalaModel();
                CART p = gr.CARTs.Find(id);

                p.Amount = product.Amount;
                p.DatePurchased = product.DatePurchased;
                p.ClientID = product.ClientID;
                p.IsInCart = product.IsInCart;
                p.ProductID = product.ProductID;

                gr.SaveChanges();
                return product.DatePurchased + "was successfully updated";

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
                CART p = gr.CARTs.Find(id);

                gr.CARTs.Attach(p);
                gr.CARTs.Remove(p);
                gr.SaveChanges();

                return p.DatePurchased + "was successfully removed";
            }
            catch (Exception e)
            {
                return "Error" + e;
            }
        }

        public List<CART> GetOrdersInCart(string userId)
        {
            shalalaModel db = new shalalaModel();
            List<CART> orders = (from x in db.CARTs
                                 where x.ClientID == userId
                                 && x.IsInCart
                                 orderby x.DatePurchased
                                 select x).ToList();
            return orders;

        }
        public int GetAmountOfOrders(string userId)
        {
            try
            {
                shalalaModel db = new shalalaModel();
                int amount = (from x in db.CARTs
                              where x.ClientID == userId
                              && x.IsInCart
                              select x.Amount).Sum();
                return amount;
            }
            catch { return 0; }
        }
        public void UpdateQuantity(int id, int quantity)
        {
            shalalaModel db = new shalalaModel();
            CART cart = db.CARTs.Find(id);
            cart.Amount = quantity;
            db.SaveChanges();
        }
        public void MArkOrderAsPaid(List<CART> carts)
        {
            shalalaModel db = new shalalaModel();

            if (carts != null)
            {
                foreach (CART cart in carts)
                {
                    CART oldCart = db.CARTs.Find(cart.Id);
                    oldCart.DatePurchased = DateTime.Now;
                    oldCart.IsInCart = false;
                }
            }
            db.SaveChanges();

        }
    }
}