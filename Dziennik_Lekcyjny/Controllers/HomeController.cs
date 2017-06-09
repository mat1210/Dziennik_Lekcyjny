using Dziennik_Lekcyjny.Models;
using Dziennik_Lekcyjny.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dziennik_Lekcyjny.ViewModels;

namespace Dziennik_Lekcyjny.Controllers
{
    public class HomeController : Controller
    {
        private dziennikContext db = new dziennikContext();
        // GET: Home
        //jjj
        public ActionResult Index()
        {
            var Nauczyciel = db.Nauczyciel.ToList();
            var Uczen = db.uczniowie.ToList();

            var ViewModel = new HomeViewModel()
            {
                Nauczyciel = Nauczyciel,
                Uczniowie = Uczen
            };
            return View(ViewModel);
        }
    }
}