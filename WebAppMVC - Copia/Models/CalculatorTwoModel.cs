using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebAppMVC.Models
{
    public class CalculatorTwoModel
    {
        [Required]
        public float? ValueOne { get; set; }

        [Required]
        public float? ValueTwo { get; set; }

        [Required]
        public IEnumerable<SelectListItem> CalculatorList
        {
            get
            {
                yield return new SelectListItem { Text = "+", Value = "1" };
                yield return new SelectListItem { Text = "-", Value = "2" };
                yield return new SelectListItem { Text = "/", Value = "3" };
                yield return new SelectListItem { Text = "*", Value = "4" };
            }
        }

        public String ClickedOperator { get; set; }

        public float? Result { get; set; }

        public string Clear { get; set; }

        public string ClearAll { get; set; }


    }
}