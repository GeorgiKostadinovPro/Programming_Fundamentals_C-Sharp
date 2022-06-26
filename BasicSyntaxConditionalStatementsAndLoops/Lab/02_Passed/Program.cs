using System;

namespace _02_Passed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            string result = grade >= 3.00 ? "Passed!" : string.Empty;

            Console.WriteLine(result);
        }
    }
}
