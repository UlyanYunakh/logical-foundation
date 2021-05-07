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
            if (formula1 == null)
            {
                ViewBag.IsFormula1 = false;
                return View();
            }
            else
            {
                if (!Formula.Check(formula1))
                    return View();
                ViewBag.IsFormula1 = true;
                ViewBag.Formula1 = formula1;
            }

            if (formula2 == null)
            {
                ViewBag.IsFormula2 = false;
                return View();
            }
            else
            {
                if (!Formula.Check(formula2))
                    return View();
                ViewBag.IsFormula2 = true;
                ViewBag.Formula2 = formula2;
            }

            ViewBag.IsCompare = Formula.Compare(formula1, formula2);

            return View();
        }
    }
}