using Adresar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adresar.Controllers
{
    public class KontaktController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Kontakt
        public ActionResult Index()
        {
            List<Kontakt> aktivniKontakti = (from k in _db.Kontakti
                                             where k.Aktivan
                                             select k).ToList();
            return View(aktivniKontakti);
        }
        // GET: Kontakt/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // POST: Kontakt/Create
        [HttpPost]
        public ActionResult Create(Kontakt kontakt)
        {
            if (ModelState.IsValid)
            {
                _db.Kontakti.Add(kontakt);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kontakt);
        }


    }
}