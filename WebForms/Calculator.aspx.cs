using System;
using System.Globalization;
using System.Windows;
using System.Web.UI;

namespace WebForms
{
    public partial class Calculator : Page
    {
        static float valueOne = 0, valueTwo = 0;
        static int operation = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnZero_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "0";
        }

        protected void BtnOne_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "1";
        }

        protected void BtnTwo_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "2";
        }

        protected void BtnThree_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "3";
        }

        protected void BtnFour_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "4";
        }

        protected void BtnFive_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "5";
        }

        protected void BtnSix_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "6";
        }

        protected void BtnSeven_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "7";
        }

        protected void BtnEight_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "8";
        }

        protected void BtnNine_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "9";
        }

        protected void BtnPoint_Click(object sender, EventArgs e)
        {
            var point = TxtResult.Text.LastIndexOf(".");

            if(point != -1)
                MessageBox.Show("Você só pode digitar apenas um '.' por número real.", "ATENÇÃO", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                TxtResult.Text += ".";
        }

        protected void BtnSum_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "")
            {
                valueOne = float.Parse(TxtResult.Text, CultureInfo.InvariantCulture);
                TxtResult.Text = "";
                operation = 1;
                LblOperation.Text = $"{valueOne} +";
                TxtResult.Focus();
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma!", "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                TxtResult.Focus();
            }
        }

        protected void BtnSub_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "")
            {
                valueOne = float.Parse(TxtResult.Text, CultureInfo.InvariantCulture);
                TxtResult.Text = "";
                operation = 2;
                LblOperation.Text = $"{valueOne} -";
                TxtResult.Focus();
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração!", "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                TxtResult.Focus();
            }
        }

        protected void BtnMult_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "")
            {
                valueOne = float.Parse(TxtResult.Text, CultureInfo.InvariantCulture);
                TxtResult.Text = "";
                operation = 4;
                LblOperation.Text = $"{valueOne} x";
                TxtResult.Focus();
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação!", "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                TxtResult.Focus();
            }
        }

        protected void BtnDiv_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "")
            {
                valueOne = float.Parse(TxtResult.Text, CultureInfo.InvariantCulture);
                TxtResult.Text = "";
                operation = 3;
                LblOperation.Text = $"{valueOne} ÷";
                TxtResult.Focus();
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão!", "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                TxtResult.Focus();
            }
        }

        protected void BtnCE_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "";
            LblOperation.Text = "";
            TxtResult.Focus();
        }

        protected void BtnC_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "";
            valueOne = 0;
            valueTwo = 0;
            LblOperation.Text = "";
            TxtResult.Focus();
        }

        protected void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text != string.Empty) 
                {
                    valueTwo = float.Parse(TxtResult.Text, CultureInfo.InvariantCulture);

                    switch (operation)
                    {
                        case 1: TxtResult.Text = ClassLibrary.Calculator.Calculate(valueOne, valueTwo, 1).ToString();
                                LblOperation.Text = $"{valueOne} + {valueTwo}"; break;
                        case 2: TxtResult.Text = ClassLibrary.Calculator.Calculate(valueOne, valueTwo, 2).ToString();
                                LblOperation.Text = $"{valueOne} - {valueTwo}"; break;
                        case 3: TxtResult.Text = ClassLibrary.Calculator.Calculate(valueOne, valueTwo, 3).ToString();
                                LblOperation.Text = $"{valueOne} ÷ {valueTwo}"; break;
                        case 4: TxtResult.Text = ClassLibrary.Calculator.Calculate(valueOne, valueTwo, 4).ToString();
                            LblOperation.Text = $"{valueOne} x {valueTwo}"; break;
                    }
                }

                TxtResult.Focus();
            }
            catch (DivideByZeroException exception) 
            {
                TxtResult.Text = exception.Message;
            }
        }
    }
}