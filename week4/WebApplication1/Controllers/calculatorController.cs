using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class calculatorController : Controller
    {
        private ICalculationService _calculator;

        public calculatorController(ICalculationService calculator)
        {
           _calculator=calculator;
        }
        public IActionResult AddTwoNumbers()
        {
            NumberModel model = new NumberModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddTwoNumbers(NumberModel numbers)

        {
            if (ModelState.IsValid)
            {
                //ICalculationService calculationService = new CalculationService();
                //NumberModel model = CalculationService.AddTwoNumbers(numbers);
                NumberModel model = _calculator.AddTwoNumbers(numbers);
                return View(model);
            }
            else
            {
                return View(numbers);
            }

        }

    }
}
