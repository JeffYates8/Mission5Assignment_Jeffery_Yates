using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission5Assignment_Jeffery_Yates.Models;

namespace Mission5Assignment_Jeffery_Yates.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }
    }
}
