using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_VehicleCatalogue
{
    public class Truck
    {
        public Truck(string brand, string model, double weight)
        { 
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }      
        
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        
        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            { 
                string[] vehicleInfo = line
                    .Split('/', StringSplitOptions.RemoveEmptyEntries);
            
                string type = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];

                if (type == nameof(Car))
                {
                    int horsePower = int.Parse(vehicleInfo[3]);
                    Car car = new Car(brand, model, horsePower);
                    catalog.Cars.Add(car);
                }
                else 
                { 
                    double weight = double.Parse(vehicleInfo[3]);
                    Truck truck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(truck);
                }
            }

            StringBuilder sb = new StringBuilder();

            if (catalog.Cars.Count > 0)
            {
                sb.AppendLine("Cars:");

                foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
                {
                    sb.AppendLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                sb.AppendLine("Trucks:");

                foreach (var truck in catalog.Trucks.OrderBy(c => c.Brand))
                {
                    sb.AppendLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            } 
            
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}