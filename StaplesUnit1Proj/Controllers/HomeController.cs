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
            
            return View();
        }

    }
}
//Wordle time
