using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Calculator
    {
        [Display(Name = "Number 1")]
        public float Num1 { get; set; }

        [Display(Name = "Number 2")]
        public float Num2 { get; set; }

        public string Operator { get; set; }

        public float? Result { get; set; }

    }
}