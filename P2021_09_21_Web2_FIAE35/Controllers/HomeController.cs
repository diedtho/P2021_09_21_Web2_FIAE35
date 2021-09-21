using Microsoft.AspNetCore.Mvc;
using P2021_09_21_Web2_FIAE35.Models;
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
            List<string> stringListe = new List<string>
            {
                "Hein", "Otto", "Ute","Berta"
            };

            //Model "füllen". Also Modelklasse instanzieren
            Input input = new Input
            {
                zaehler = zaehler,
                zeit = aktuelleZeit,
                stringListe = stringListe
            };

        /*
            ViewBag.Counter = zaehler;
            ViewBag.Zeit = aktuelleZeit;
            ViewBag.Namen = StringListe;
        */
            return View();
        }
    }
}
