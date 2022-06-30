using System;

namespace _06_TriplesOfLatinLetters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + number; i++)
            {
                for (char j = 'a'; j < 'a' + number; j++)
                {
                    for (char k = 'a'; k < 'a' + number; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
