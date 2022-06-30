using System;

namespace _08_BeerKegs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numbersOfBeerKegs = int.Parse(Console.ReadLine());
            double biggestKeg = 0.0D;
            string kegName = string.Empty;

            for (int i = 0; i < numbersOfBeerKegs; i++)
            {
                string modelOfTheKeg = Console.ReadLine();
                double radiusOfTheKeg = double.Parse(Console.ReadLine());
                double heightofTheKeg = double.Parse(Console.ReadLine());

                double volume = Math.PI * radiusOfTheKeg * radiusOfTheKeg * heightofTheKeg;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    kegName = modelOfTheKeg;
                }
            }

            Console.WriteLine(kegName);
        }
    }
}
