using System;
using System.Linq;

namespace _03_SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TraveledDistance { get; set; }

        public void Drive(double amountOfKilometers)
        {
            double neededFuel = this.FuelConsumptionPerKilometer * amountOfKilometers;

            if (this.FuelAmount >= neededFuel)
            {
                this.FuelAmount -= neededFuel;
                this.TraveledDistance += amountOfKilometers;
            }
            else 
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TraveledDistance}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            Car[] cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars[i] = car;
            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmdArgs[0];
                string model = cmdArgs[1];
                double amountOfKilometers = double.Parse(cmdArgs[2]);

                Car car = cars.FirstOrDefault(c => c.Model == model);
                car.Drive(amountOfKilometers);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}