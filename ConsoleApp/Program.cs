using ClassLibrary;
using ConsoleApp.Classes;
using static System.Console;

namespace ConsoleCalculator
{
    public class Program 
    {   
        private static Person person = new();
        public static string option = "";
        
        static void Main(string[] args)
        {
            Centralize.CentralizeC();
            Title = "Calculator";
            BackgroundColor = ConsoleColor.DarkCyan;
            ForegroundColor = ConsoleColor.White;

            WelcomeScreen();
        }

        private static void WelcomeScreen()
        {
            Clear();

            WriteLine(@"                                  -------------------------                          
                      ______      _             _           _                  
                     / _____)    | |           | |         | |                 
                    | /      ____| | ____ _   _| | ____  _ | | ___   ____ ____ 
                    | |     / _  | |/ ___| | | | |/ _  |/ || |/ _ \ / ___/ _  |
                    | \____( ( | | ( (___| |_| | ( ( | ( (_| | |_| | |  ( ( | |
                     \______\_||_|_|\____)\____|_|\_||_|\____|\___/|_|   \_||_|
                                                                               
                                  -------------------------                         
                                                                                    
                                  -------------------------                         
                                       Seja Bem-Vindo!                            
                                  -------------------------                         
             ");

            Thread.Sleep(2000);

            WriteLine(@"                                 ----------------------------                      
                                 Olá, digite seu NOME abaixo:                       
                                 ----------------------------
            ");

            string name = ReadLine();

            Clear();

            person.SetName(name);

            WriteLine("                              ---------------------------------------------           ");
            WriteLine($"                            Vamos lá {person.Name}, partiu fazer umas operações?     ");
            WriteLine(@"       
                              ---------------------------------------------          
                             Para responder tecle 's' para SIM ou 'n' para NÃO:       
                              ---------------------------------------------           
             ");

            option = ReadLine().ToLower();

            switch (option)
            {
                case "n": Clear();
                        WriteLine(@"                                                 ----------------------------                       
                                             NÃO??!! QUE PENA, DEIXA PARA PRÓXIMA                   
                                                 ---------------------------- 
                        ");
                        Thread.Sleep(2000); break;
                case "s": ScreenOne(person); break;
                default:WriteLine(@"                                                ----------------------------                       
                                                    !!OPÇÃO INVÁLIDA!!                             
                                                ----------------------------                       
                ");
                        Thread.Sleep(2000);
                        ReturnScreen(person); break;
            }
        }   
        
        private static void ScreenOne(Person person)
        {
            Clear();                   

            WriteLine("                               ---------------------------------------------           ");
            WriteLine($"                                {person.Name}, insira o tipo de OPERAÇÃO desejada:        ");
            WriteLine(@"                               ---------------------------------------------           
                                                                           
                                    Operações disponíveis: + , - , * , /              
                               ---------------------------------------------          
            ");

            option = ReadLine();

            switch (option)
            {
                case "+": SumScreen(person); break;
                case "-": SubScreen(person); break;
                case "*": MultScreen(person); break;
                case "/": DivScreen(person); break;
                default:  WriteLine(@"                                                  ----------------------------                       
                                                        !!OPÇÃO INVÁLIDA!!                             
                                                  ----------------------------                       
                ");
                          Thread.Sleep(2000);
                          ScreenOne(person); break;
            }
        }
        private static void SumScreen(Person person)
        {
            Clear();

            float numberOne;
            float numberTwo;

            WriteLine(@"                                                           
                              ---------------------------------------------          
                             Para efetuar uma SOMA, insira o PRIMEIRO valor:         
                              ---------------------------------------------           
            ");
            numberOne = float.Parse(ReadLine());

            WriteLine(@"                                                  
                             ---------------------------------------------          
                                 Agora insira o SEGUNDO VALOR desejado:             
                             ---------------------------------------------           ");
            numberTwo = float.Parse(ReadLine());

            Clear();

            WriteLine(@"                                                               
                              ---------------------------------------------           ");
            WriteLine($"                 Finalmente {person.Name}, o resultado da SOMA é : " +
                $"► {Calculator.Calculate(numberOne, numberTwo, 1)} ◄");
            WriteLine("                              ---------------------------------------------           ");

            Thread.Sleep(3000);
            ReturnScreen(person);
        }

        private static void SubScreen(Person person)
        {
            Clear();

            float numberOne;
            float numberTwo;

            WriteLine(@"                                                           
                              ---------------------------------------------          
                           Para efetuar uma SUBTRAÇÃO, insira o PRIMEIRO valor:         
                              ---------------------------------------------           
            ");
            numberOne = float.Parse(ReadLine());

            WriteLine(@"                                                  
                             ---------------------------------------------          
                                 Agora insira o SEGUNDO VALOR desejado:             
                             ---------------------------------------------           ");
            numberTwo = float.Parse(ReadLine());

            Clear();

            WriteLine(@"                                                               
                              ---------------------------------------------           ");
            WriteLine($"                 Finalmente {person.Name}, o resultado da SUBTRAÇÃO é : " +
                $"► {Calculator.Calculate(numberOne, numberTwo, 2)} ◄");
            WriteLine("                              ---------------------------------------------           ");

            Thread.Sleep(3000);
            ReturnScreen(person);
        }

        private static void MultScreen(Person person)
        {
            Clear();

            float numberOne;
            float numberTwo;

            WriteLine(@"                                                           
                              ---------------------------------------------          
                          Para efetuar uma MULTIPLICAÇÃO, insira o PRIMEIRO valor:         
                              ---------------------------------------------           
            ");
            numberOne = float.Parse(ReadLine());

            WriteLine(@"                                                  
                             ---------------------------------------------          
                                 Agora insira o SEGUNDO VALOR desejado:             
                             ---------------------------------------------           ");
            numberTwo = float.Parse(ReadLine());

            Clear();

            WriteLine(@"                                                               
                              ---------------------------------------------           ");
            WriteLine($"                 Finalmente {person.Name}, o resultado da MULTIPLICAÇÃO é : " +
                $"► {Calculator.Calculate(numberOne, numberTwo, 4)} ◄");
            WriteLine("                              ---------------------------------------------           ");

            Thread.Sleep(3000);
            ReturnScreen(person);
        }

        private static void DivScreen(Person person)
        {
            Clear();

            float numberOne;
            float numberTwo;
            WriteLine(@"                                                           
                              ---------------------------------------------          
                             Para efetuar uma DIVISÃO, insira o PRIMEIRO valor:         
                              ---------------------------------------------           
            ");
            numberOne = float.Parse(ReadLine());

            WriteLine(@"                                                  
                             ---------------------------------------------          
                                 Agora insira o SEGUNDO VALOR desejado:             
                             ---------------------------------------------           ");
            numberTwo = float.Parse(ReadLine());

            Clear();

            try
            {
                WriteLine(@"                                                               
                              ---------------------------------------------           ");
                WriteLine($"                 Finalmente {person.Name}, o resultado da DIVISÃO é : " +
                    $"► {Calculator.Calculate(numberOne, numberTwo, 3)} ◄");
                WriteLine("                              ---------------------------------------------           ");

                Thread.Sleep(3000);
                ReturnScreen(person);
            }
            catch (DivideByZeroException exception)
            {
                WriteLine($"{exception.Message}");
                Thread.Sleep(3000);

                ReturnScreen(person);
            }
        }

        private static void ReturnScreen(Person person)
        {
            Clear();

            WriteLine(@"                                                               
                                ---------------------------------------------           
                                   1 - Fazer outra OPERAÇÃO                             
                                ---------------------------------------------           
                                   2 - SAIR da Calculadora                              
                                ---------------------------------------------           ");

            option = ReadLine();

            switch (option)
            {
                case "1": ScreenOne(person); break;
                case "2": ReadLine(); break;
                default: WriteLine(@"                                        ----------------------------                       
                                              !!OPÇÃO INVÁLIDA!!                             
                                        ----------------------------                       
                ");
                Thread.Sleep(2000);
                ReturnScreen(person); break;
            }
        }
    }
}       