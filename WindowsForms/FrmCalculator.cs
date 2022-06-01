﻿using ClassLibrary;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmCalculator : Form
    {
        float valueOne = 0, valueTwo = 0;
        int operation = 0;
        CultureInfo Culture = new CultureInfo("pt-BR");

        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Load(object sender, EventArgs e) { }

        private void LblOperation_Click(object sender, EventArgs e) { }

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtResult.Text = string.Format(Culture, "{0:N0}",  float.Parse(TxtResult.Text));
                //Calculator.StringFormat(TxtResult.Text);
            }
            catch (Exception exception)
            {
                TxtResult.Text = exception.Message;
            }
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "0";
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "1";
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "2";
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "3";
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "4";
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "5";
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "6";
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "7";
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "8";
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "9";
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            var point = TxtResult.Text.IndexOf(",");

            if (point != -1)
                TxtResult.Select();
            else
                TxtResult.Text += ",";
            
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != string.Empty)
            {
                valueOne = float.Parse(TxtResult.Text, Culture);
                TxtResult.Text = string.Empty;
                operation = 1;
                LblOperation.Text = $"{valueOne.ToString("N", Culture)} +";
                TxtResult.Select();               
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma!", "ATENÇÃO!", MessageBoxButtons.OK,  MessageBoxIcon.Information );
                TxtResult.Select();
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != string.Empty)
            {
                valueOne = float.Parse(TxtResult.Text, Culture);
                TxtResult.Text = string.Empty;
                operation = 2;
                LblOperation.Text = $"{valueOne.ToString("N0")} -";
                TxtResult.Select();
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtResult.Select();
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != string.Empty)
            {
                valueOne = float.Parse(TxtResult.Text, Culture);
                TxtResult.Text = string.Empty;
                operation = 4;
                LblOperation.Text = $"{valueOne.ToString("N0")} x";
                TxtResult.Select();
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtResult.Select();
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != string.Empty)
            {
                valueOne = float.Parse(TxtResult.Text, Culture);
                TxtResult.Text = string.Empty;
                operation =  3;
                LblOperation.Text = $"{valueOne.ToString("N0")} ÷";
                TxtResult.Select();
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtResult.Select();
            }
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtResult.Text = string.Empty;
            LblOperation.Text = string.Empty;
            TxtResult.Select();
        }      

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtResult.Text = string.Empty;
            valueOne = 0;
            valueTwo = 0;
            LblOperation.Text = string.Empty;
            TxtResult.Select();
        }
       
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text != string.Empty)
                {
                    valueTwo = float.Parse(TxtResult.Text, Culture);

                    switch (operation)
                    {
                        case 1: 
                            TxtResult.Text = Calculator.Calculate(valueOne, valueTwo, 1).ToString();
                            LblOperation.Text = $"{valueOne.ToString("N0")} + {valueTwo.ToString("N0")}";
                            break;
                        case 2: 
                            TxtResult.Text = Calculator.Calculate(valueOne, valueTwo, 2).ToString();
                            LblOperation.Text = $"{valueOne.ToString("N0")} - {valueTwo.ToString("N0")}";
                            break;                            
                        case 3: 
                            TxtResult.Text = Calculator.Calculate(valueOne, valueTwo, 3).ToString();
                            LblOperation.Text = $"{valueOne.ToString("N0")} ÷ {valueTwo.ToString("N0")}";
                            break;
                        case 4: 
                            TxtResult.Text = Calculator.Calculate(valueOne, valueTwo, 4).ToString();
                            LblOperation.Text = $"{valueOne.ToString("N0")} x {valueTwo.ToString("N0")}";
                            break;                            
                    }
                }

                TxtResult.Select();
            }
            catch (DivideByZeroException exception) // Esse que é pego pela exeção por ser mais funilado!
            {
                TxtResult.Text = exception.Message;
            }
            catch (Exception exception) // Esse tem um leque maior de exeções, por isso fica em segundo plano!
            {
                TxtResult.Text = exception.Message;
            }
        }                                          
    }
}