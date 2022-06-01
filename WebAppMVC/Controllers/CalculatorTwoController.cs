using ClassLibrary;
using System;
using System.Web.Mvc;
using WebAppMVC.Models;
namespace WebAppMVC.Controllers
{
    public class CalculatorTwoController : Controller
    {
        private CalculatorTwoModel GetModel(CalculatorTwoModel model)
        {
            try
            {
                if (ModelState.IsValid)
                    model.Result = Calculator.Calculate((float)model.ValueOne, (float)model.ValueTwo, Convert.ToInt32(model.SelectedOperator));
            }
            catch (DivideByZeroException exception)
            {
                throw new Exception(exception.Message);
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return model;
        }

        public ViewResult Index()
        {
            return View(new CalculatorTwoModel());
        }

        [HttpPost]
        public JsonResult Calculate(CalculatorTwoModel model)
        {
            try
            {
                return Json(GetModel(model));
            }
            catch (Exception exception)
            {
                return Json(new { result = false, error = exception.Message });
            }
        }
    }
}