using System.Globalization;

namespace ClassLibrary
{
    /// <summary>
    /// Classe responsável pelas operações aritméticas.
    /// </summary>
    public class Calculator 
    {
        /// <summary>
        /// Método responsável por realizar a operação matemática básica.
        /// </summary>
        /// <param name="number1">Primeiro valor.</param>
        /// <param name="number2">Segundo valor.</param>
        /// <param name="operators">Operador matemático.</param>
        /// <example>
        ///     1 = adição. 
        ///     2 = subtração.
        ///     3 = divisão.
        ///     4 = multiplicação.
        /// </example>
        /// <returns>Retorna um inteiro.</returns>
        public static float Calculate(float number1, float number2, int operators)
        {
            float result = 0;

            if (number2 == 0 && operators == 3)
            {
                throw new DivideByZeroException("Não existe divisão por 0.");                
            }

            switch (operators)
            {
                case 1: result = number1 + number2; break;
                case 2: result = number1 - number2; break;
                case 3: result = number1 / number2; break;
                case 4: result = number1 * number2; break;
            }

            return result;
        }

        public static string StringFormat(string TxtResult)
        {
            if (TxtResult != string.Empty)
            {
                TxtResult = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N0}", float.Parse(TxtResult));
            }
            else
            {
                TxtResult = string.Empty;
            }

            return TxtResult ;
        }
    }
}