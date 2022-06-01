using System;

namespace Test
{
    public partial class CalculatorTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            switch (TxtOperation.Text)
            {
                case "+": TxtResult.Text = (Convert.ToDecimal(TxtNumOne.Text) + Convert.ToDecimal(TxtNumTwo.Text)).ToString(); break;
                case "-": TxtResult.Text = (Convert.ToDecimal(TxtNumOne.Text) - Convert.ToDecimal(TxtNumTwo.Text)).ToString(); break;
                case "*": TxtResult.Text = (Convert.ToDecimal(TxtNumOne.Text) * Convert.ToDecimal(TxtNumTwo.Text)).ToString(); break;
                case "/": TxtResult.Text = (Convert.ToDecimal(TxtNumOne.Text) / Convert.ToDecimal(TxtNumTwo.Text)).ToString(); break;
            }
        }
    }
}