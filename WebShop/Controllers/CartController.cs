using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class CartController : Controller
    {
        private WebShopEntities db = new WebShopEntities();
        public static List<Proizvodi> lstProizvodi = new List<Proizvodi>();
        // GET: Cart
        public ActionResult Index()
        {
            if (Session["Cart"] != null)
            {
                lstProizvodi = Session["Cart"] as List<Proizvodi>;
            }

            return View(lstProizvodi);
        }
        // GET: Cart/AddToCart/{id}
        public ActionResult AddToCart(int id)
        {
            /*
            if (Session["Cart"] != null)
            {
                lstProizvodi = Session["Cart"] as List<Proizvodi>;
            }
            */
            Proizvodi proizvodi = db.Proizvodis.Find(id);
            lstProizvodi.Add(proizvodi);
            Session["Cart"] = lstProizvodi;
            if(proizvodi == null)
            {
                return HttpNotFound("greska:Proizvod nije nadjen");
            }
            var proi = db.Proizvodis.Include(p => p.MjereProizvoda);
            return RedirectToAction("Index", "WebShop", proi.ToList()); //proizvodi.ToList());
            //return View(lstProizvodi);
        }
    }
}