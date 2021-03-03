using System;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class Home : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(false);
        }

        [HttpPost]
        public IActionResult Index(string text)
        {
            return View(true);
        }
    }
}