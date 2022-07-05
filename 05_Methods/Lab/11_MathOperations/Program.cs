using System;

namespace _11_MathOperations
{
    public class Program
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, secondNumber, @operator);
            Console.WriteLine(result);
        }

        private static double Calculate(double firstNumber, double secondNumber, char @operator)
        {
            if (@operator == '+')
            {
                return firstNumber + secondNumber;
            }
            else if (@operator == '-')
            {
                return firstNumber - secondNumber;
            }
            else if (@operator == '*')
            {
                return firstNumber * secondNumber;
            }

            return firstNumber / secondNumber;
        }
    }
}
