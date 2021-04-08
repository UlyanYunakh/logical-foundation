using System;
using FormulaLib;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class Home : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string text)
        {
            bool isFormula = Formula.Check(text);
            bool isDNF = false;

            if (isFormula)
                isDNF = DNF.Check(text);

            ViewBag.IsFormula = isFormula;
            ViewBag.IsDNF = isDNF;

            return View();
        }
    }
}