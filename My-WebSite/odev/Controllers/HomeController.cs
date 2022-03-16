using System;
using System.Collections.Generic;
using System.Globalization;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev.Models;

namespace odev.Controllers  // konular veri tabanında olacak silme adminde, ekleme uye de olacak
{
    public class HomeController : Controller
    {
        private konularEntities2 db = new konularEntities2();
        public ActionResult dilDegistir(string lang, string returnUrl)
        {
            Session["Dil"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }

        public ActionResult Index()
        {
            return View(db.Resim.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [Authorize]
        public ActionResult Mesaj()
        {
            return View();
        }
        [Authorize(Users ="uhudhanx@gmail.com")]
        public ActionResult Yonet()
        {
            return View();
        }
    }
}