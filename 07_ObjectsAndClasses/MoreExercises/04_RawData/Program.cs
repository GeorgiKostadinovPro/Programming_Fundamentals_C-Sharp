using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_RawData
{
    public class Cargo
    {
        public int CargoWeight { get; set; }

        public string CargoType { get; set; }
    }

    public class Engine
    {
        public int Power { get; set; }

        public int Speed { get; set; }
    }

    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Cargo = cargo;
            this.Engine = engine;
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Cargo> cargos = new List<Cargo>();
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = info[0];
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                int cargoWeight = int.Parse(info[3]);
                string cargoType = info[4];

                Cargo cargo = cargos.FirstOrDefault(c => c.CargoType == cargoType && c.CargoWeight == cargoWeight);


                if (cargo == null)
                {
                    cargo = new Cargo()
                    {
                        CargoType = cargoType,
                        CargoWeight = cargoWeight,
                    };

                    cargos.Add(cargo);
                }

                Engine engine = engines.FirstOrDefault(e => e.Power == enginePower && e.Speed == engineSpeed);

                if (engine == null)
                {
                    engine = new Engine()
                    {
                        Speed = engineSpeed,
                        Power = enginePower,
                    };

                    engines.Add(engine);
                }

                Car car = new Car(model, engine, cargo);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.CargoType == command && c.Cargo.CargoWeight < 1000))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(c => c.Cargo.CargoType == command && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}