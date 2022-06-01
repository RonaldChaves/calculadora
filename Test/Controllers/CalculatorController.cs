using System;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculator calculator)
        {
            ModelState.Clear();
            switch (calculator.Operator)
            {
                case "+": calculator.Result = calculator.Num1 + calculator.Num2; break;
                case "-": calculator.Result = calculator.Num1 - calculator.Num2; break;
                case "*": calculator.Result = calculator.Num1 * calculator.Num2; break;
                case "/": calculator.Result = calculator.Num1 / calculator.Num2; break;
            }

            return View(calculator);
        }
    }
}