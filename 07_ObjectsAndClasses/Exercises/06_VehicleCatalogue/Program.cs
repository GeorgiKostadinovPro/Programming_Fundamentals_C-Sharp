using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_VehicleCatalogue
{
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string type = this.Type
                .Substring(0, 1)
                .ToUpper() + this.Type
                .Substring(1);

            sb.AppendLine($"Type: {type}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Horsepower: {this.HorsePower}");

            return sb.ToString().TrimEnd();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehcileInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = vehcileInfo[0];
                string model = vehcileInfo[1];
                string color = vehcileInfo[2];
                int horsePower = int.Parse(vehcileInfo[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);
            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = line;

                Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == model);

                Console.WriteLine(vehicle.ToString());
            }

            double carsAverageHorsePower = vehicles.Count(v => v.Type.ToLower() == "car") > 0 
                ? vehicles.Where(v => v.Type.ToLower() == "car").Average(v => v.HorsePower)
                : 0;

            double trucksAverageHorsePower = vehicles.Count(v => v.Type.ToLower() == "truck") > 0 
                ? vehicles .Where(v => v.Type.ToLower() == "truck").Average(v => v.HorsePower)
                : 0;

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:f2}.");
        }
    }
}