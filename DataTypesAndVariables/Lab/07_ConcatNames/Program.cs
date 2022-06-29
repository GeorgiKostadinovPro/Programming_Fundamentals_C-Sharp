using System;

namespace _07_ConcatNames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine(firstName + delimiter + secondName);
        }
    }
}
