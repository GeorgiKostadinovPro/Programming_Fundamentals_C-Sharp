using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_NeedForSpeedThree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cars = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carsInput = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string car = carsInput[0];
                int mileAge = int.Parse(carsInput[1]);
                int fuel = int.Parse(carsInput[2]);

                cars.Add(car, new List<int>() { mileAge, fuel });
            }

            string line;

            while ((line = Console.ReadLine()) != "Stop")
            {
                string[] commands = line.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];
                string car = commands[1];

                switch (command)
                {
                    case "Drive":
                        int distance = int.Parse(commands[2]);
                        int fuel = int.Parse(commands[3]);

                        if (cars[car][1] < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[car][1] -= fuel;
                            cars[car][0] += distance;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }

                        if (cars[car][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(car);
                        }

                        break;
                    case "Refuel":
                        int fuelToRefuel = int.Parse(commands[2]);
                        int increasedFuel = cars[car][1] + fuelToRefuel;

                        if (increasedFuel > 75)
                        {
                            int lowered = increasedFuel - 75;
                            int left = fuelToRefuel - lowered;
                            cars[car][1] += left;
                            Console.WriteLine($"{car} refueled with {left} liters");
                        }
                        else
                        {
                            cars[car][1] += fuelToRefuel;
                            Console.WriteLine($"{car} refueled with {fuelToRefuel} liters");
                        }
                        break;
                    case "Revert":
                        int kilometers = int.Parse(commands[2]);
                        int mileAge = cars[car][0] - kilometers;

                        if (mileAge < 10000)
                        {
                            cars[car][0] = 10000;
                            break;
                        }
                        else
                        {
                            cars[car][0] -= kilometers;
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (var car in cars.OrderByDescending(c => c.Value[0]).OrderBy(c => c.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
