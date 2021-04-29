using FormulaLib;
using Microsoft.AspNetCore.Mvc;

// Ulyan Yunakh, 821704, Lab-2 LOIS

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
        public IActionResult Index(string formula1, string formula2)
        {
            ViewBag.IsFormula1 = false;
            ViewBag.Formula1 = formula1;

            ViewBag.IsFormula2 = false;
            ViewBag.Formula2 = formula2;
            
            ViewBag.IsCompare = false;

            if (formula1 != null && formula2 != null)
            {
                if (!Formula.Check(formula1))
                    return View();
                ViewBag.IsFormula1 = true;

                if (!Formula.Check(formula2))
                    return View();
                ViewBag.IsFormula2 = true;
                
                ViewBag.IsCompare = Formula.Compare(formula1, formula2);
            }

            return View();
        }
    }
}