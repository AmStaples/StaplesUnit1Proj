using Microsoft.AspNetCore.Mvc;
using StaplesUnit1Proj.Models;
using System.Diagnostics;

namespace StaplesUnit1Proj.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet] 
        public IActionResult Index() 
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult Index(Wordle w) 
        {
            ViewBag.answerInput = w.answer;
            return View("Game" , w);
        }

        [HttpGet]
        public IActionResult Game(Wordle w)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Game(Wordle w)
        {

            if (ModelState.IsValid)
            {
                
                w.CheckSlot();

                if (w.slot1status == 1) { ViewBag.slot1 = "Wrong Letter"; }
                else if (w.slot1status == 2) { ViewBag.slot1 = "Wrong Spot"; }
                else if (w.slot1status == 3) { ViewBag.slot1 = "Correct Letter"; }

                if (w.slot2status == 1) { ViewBag.slot2 = "Wrong Letter"; }
                else if (w.slot2status == 2) { ViewBag.slot2 = "Wrong Spot"; }
                else if (w.slot2status == 3) { ViewBag.slot2 = "Correct Letter"; }

                if (w.slot3status == 1) { ViewBag.slot3 = "Wrong Letter"; }
                else if (w.slot3status == 2) { ViewBag.slot3 = "Wrong Spot"; }
                else if (w.slot3status == 3) { ViewBag.slot3 = "Correct Letter"; }

                if (w.slot4status == 1) { ViewBag.slot4 = "Wrong Letter"; }
                else if (w.slot4status == 2) { ViewBag.slot4 = "Wrong Spot"; }
                else if (w.slot4status == 3) { ViewBag.slot4 = "Correct Letter"; }

                if (w.slot5status == 1) { ViewBag.slot5 = "Wrong Letter"; }
                else if (w.slot5status == 2) { ViewBag.slot5 = "Wrong Spot"; }
                else if (w.slot5status == 3) { ViewBag.slot5 = "Correct Letter"; }
                return View();
            }
            else 
            {
                ViewBag.Answer = w.answer;
                ViewBag.Input = w.input;
                ViewBag.Valid = "Invalid entry please only use 5 leter words";
                return View(); 
            }
           
        }

    }
}
//Wordle time
