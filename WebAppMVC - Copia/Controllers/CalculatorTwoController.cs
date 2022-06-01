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
            if(ModelState.IsValid)
                model.Result = Calculator.Calculate((float)model.ValueOne, (float)model.ValueTwo, Convert.ToInt32(model.ClickedOperator));

            return model;
        }

        public ViewResult Index()
        {
            return View(new CalculatorTwoModel());
        }

        [HttpPost]
        public ActionResult Index(CalculatorTwoModel model)
        {
            return View(GetModel(model));
        }


        //// GET: CalculatorTwo
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}