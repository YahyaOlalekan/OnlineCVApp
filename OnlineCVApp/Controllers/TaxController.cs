using Microsoft.AspNetCore.Mvc;
using OnlineCVApp.Models;

namespace OnlineCVApp.Controllers
{
    public class TaxController : Controller
    {
        [HttpGet]
        public IActionResult Calculate() => View();

        [HttpPost]
        public IActionResult Calculate(decimal annualIncome)
        {
            var calculator = new TaxCalculator();
            decimal tax = calculator.CalculateTax(annualIncome);
            ViewBag.Tax = tax;
            ViewBag.Income = annualIncome;
            return View();
        }
    }
}
