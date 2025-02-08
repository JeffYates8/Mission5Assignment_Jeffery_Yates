using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission5Assignment_Jeffery_Yates.Models;

namespace Mission5Assignment_Jeffery_Yates.Controllers // groups the related classes and keeps organized
{
    public class HomeController : Controller // inherits from the controller base class
    {
        public IActionResult Index() // when called, returns the home HTML page
        {
            return View();
        }

        public IActionResult Calculator() // when called, returns the calculator HTML page
        {
            return View();
        }
    }
}
