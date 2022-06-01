using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebAppMVC.Models
{
    public class CalculatorModel
    {
        [Required]
        [Display(Name = "Number One:")]
        public float? NumberOne { get; set; }

        [Required]
        [Display(Name = "Number Two:")]
        public float? NumberTwo { get; set; }

        [Required]
        [Display(Name = "Operators:")]
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

        public String SelectedOperator { get; set; }

        [Display(Name = "Result:")]
        public float? Result { get; set; }
    }
}