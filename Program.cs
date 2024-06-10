using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Podaj 1 liczbę:");

                var number1 = GetInput();

                Console.WriteLine("Jaką operacje chcesz wykonać? Możliwe operacje to:  '+', '-', '/', '*'.");
                var action = Console.ReadLine();

                Console.WriteLine("Podaj 2 liczbę:");
                var number2 = GetInput();

                var result = Calculate(number1, number2, action);

                Console.WriteLine("Wynik Twojego działania to: " + result);
            }
            catch (Exception ex)
            {
               //logowanie do pliku
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))

                throw new Exception("Podana wartość jest nieprawidłowa");

            return input;

        }

        private static int Calculate(int number1, int number2, string action)
        {
            switch (action)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "/":
                    return number1 / number2;
                case "*":
                    return number1 * number2;
                default:
                    throw new Exception("Wybrałeś złą operację!");
            }
        }
    }
}

