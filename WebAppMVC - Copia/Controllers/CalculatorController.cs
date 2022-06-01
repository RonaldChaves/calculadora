using ClassLibrary;
using System;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class CalculatorController : Controller
    {
        #region Methods
        /// <summary>
        /// Retorna a ViewModel (Modelo da visão) para os Results.
        /// </summary>
        /// <param name="model">CalculatorModel view model</param>
        /// <returns>Retorna a view model com os valores atualizados</returns>
        private CalculatorModel GetModel(CalculatorModel model)
        {
            if (ModelState.IsValid)
                model.Result = Calculator.Calculate((float)model.NumberOne, (float)model.NumberTwo, Convert.ToInt32(model.SelectedOperator));

            return model;
        }
        #endregion

        #region Results
        public ViewResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult Index(CalculatorModel model)
        {
            return View(GetModel(model));
        }

        [HttpPost]
        public JsonResult Calculate(CalculatorModel model)
        {
            return Json(GetModel(model));
        }

        [HttpGet]
        public JsonResult GetCalculate(CalculatorModel model)
        {
            return Json(GetModel(model), JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}