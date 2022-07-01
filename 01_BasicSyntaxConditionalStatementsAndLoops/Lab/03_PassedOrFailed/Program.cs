using System;

namespace _03_PassedOrFailed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            string result = grade >= 3.00 ? "Passed!" : "Failed!";

            Console.WriteLine(result);
        }
    }
}
