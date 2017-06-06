using Dziennik_Lekcyjny.Models;
using Dziennik_Lekcyjny.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dziennik_Lekcyjny.Controllers
{
    public class HomeController : Controller
    {
        private dziennikContext db = new dziennikContext();
        // GET: Home
        public ActionResult Index()
        {
            Uczen Uczen = new Uczen { Imie = "Adam", Nazwisko = "Stano" };
            db.uczniowie.Add(Uczen);
            db.SaveChanges();
            return View();
        }
    }
}