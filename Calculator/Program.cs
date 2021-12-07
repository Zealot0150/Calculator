using System;
using static System.Console;


namespace Calculator
{
    class Program
    {

        static double ReadUserDouble()
        {
            double userInput = 0;
            bool hasUserMakedTheIput = false;
            do
            {
                if (Double.TryParse(ReadLine(), out userInput))
                    hasUserMakedTheIput = true;
                else
                    WriteLine("Felaktikigt format, ange ett tal");
            }
            while (!hasUserMakedTheIput);
            return userInput;
        }

        static string ReadUserOperand()
        {
            string userInput = "";
            bool hasUserMakedTheIput = false;
            do
            {
                userInput = Console.ReadLine();
                if ((userInput == "*") ||
                    (userInput == "/") ||
                    (userInput == "+") ||
                    (userInput == "-"))
                    hasUserMakedTheIput = true;

                else
                    WriteLine("Felaktikigt format, ange någon av operanderna * / + -");

               }while (!hasUserMakedTheIput);
            return userInput;
        }
        
        
        static void Addition(double firstArgument, double secondArgument)
        {
            double result = firstArgument + secondArgument;
            WriteLine(($"{firstArgument} + {secondArgument} = {result}"));
        
        }
        
        static void Division(double firstArgument, double secondArgument)
        {
            double result;
            if (secondArgument == 0)
                WriteLine(($"{firstArgument} / {secondArgument} = 0"));

            else
            {
                result = firstArgument / secondArgument;
                WriteLine(($"{firstArgument} / {secondArgument} = {result}"));
            }
        }

        static void Subtraction(double firstArgument, double secondArgument)
        {
            double result = firstArgument - secondArgument;
            WriteLine(($"{firstArgument} - {secondArgument} = {result}"));
        }

        
        static void Multiplication(double firstArgument, double secondArgument)
        {
            double result = firstArgument * secondArgument;
            WriteLine(($"{firstArgument} * {secondArgument} = {result}"));
        }



        static void Main(string[] args)
        {
            bool running = true;
            WriteLine("Välkommen till calculatorn version 1.0");
            double firstArgument, secondArgument = 0;
            string userOperator = "";
            while(running)
            {
                WriteLine("Skriv in ditt första tal");
                firstArgument = ReadUserDouble();
                WriteLine("Skriv in operand, välj mellan * / + - ");
                userOperator = ReadUserOperand();
                WriteLine("Skriv in ditt andra tal");
                secondArgument = ReadUserDouble();
                switch (userOperator)
                {
                    case "*":
                        Multiplication(firstArgument, secondArgument);
                        break;
                    case "/":
                        Division(firstArgument, secondArgument);
                        break;
                    case "+":
                        Addition(firstArgument, secondArgument);
                        break;
                    case "-":
                        Subtraction(firstArgument, secondArgument);
                        break;

                    default:
                        WriteLine("Something strange has happened, call the suport");
                        break;
                }

                WriteLine("Vill du avsluta, tryck y plus enter annars bara enter för ny beräkning");
                if (ReadLine() == "y")
                    Environment.Exit(0);
            }

        }
    }
}
