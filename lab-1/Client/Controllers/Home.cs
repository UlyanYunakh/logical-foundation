using FormulaLib;
using Microsoft.AspNetCore.Mvc;

// Ulyan Yunakh, 821704, Lab-1 LOIS, Variant F

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
            if (text != null)
            {
                bool isFormula = Formula.Check(text);
                bool isDNF = false;

                if (isFormula)
                    isDNF = DNF.Check(text);

                ViewBag.IsFormula = isFormula;
                ViewBag.IsDNF = isDNF;
                ViewBag.Text = text;
            }

            return View();
        }
    }
}