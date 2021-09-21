using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2021_09_21_Web2_FIAE35.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Ganz viel Code
            int zaehler = 100;
            DateTime aktuelleZeit = DateTime.Now;
            List<string> StringListe = new List<string>
            {
                "Hein", "Otto", "Ute","Berta"
            };

            ViewBag.Counter = zaehler;
            ViewBag.Zeit = aktuelleZeit;
            ViewBag.Namen = StringListe;

            return View();
        }
    }
}
