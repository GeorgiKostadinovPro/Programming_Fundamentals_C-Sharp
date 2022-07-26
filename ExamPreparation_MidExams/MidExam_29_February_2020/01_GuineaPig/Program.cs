using System;

namespace _01_GuineaPig
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double foodQuantityKg = double.Parse(Console.ReadLine()) * 1000;
            double hayQuantityKg = double.Parse(Console.ReadLine()) * 1000;
            double coverQuantityKg = double.Parse(Console.ReadLine()) * 1000;
            double guineasWeight = double.Parse(Console.ReadLine()) * 1000;

            double guineasBaseWeight = guineasWeight;

            bool isEnough = true;

            for (int i = 1; i <= 30; i++)
            {
                foodQuantityKg -= 300;
                guineasWeight += 300;

                if (i % 2 == 0)
                {
                    double hayNeeded = foodQuantityKg * 0.05;
                    hayQuantityKg -= hayNeeded;
                    guineasWeight += hayNeeded;
                }

                if (i % 3 == 0)
                {
                    double coverNeeded = 0.33333333333 * guineasBaseWeight;
                    coverQuantityKg -= coverNeeded;
                }

                if (foodQuantityKg < 300 || hayQuantityKg < 0 || coverQuantityKg < 0)
                {
                    isEnough = false;
                    break;
                }
            }

            if (isEnough == true)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodQuantityKg / 1000.0):f2}, Hay: {(hayQuantityKg / 1000.0):f2}, Cover: {(coverQuantityKg / 1000.0):f2}.");
            }
            else
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }
        }
    }
}
