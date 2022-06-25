using System;
using System.Linq;

namespace SpaceTravel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var travelRoute = Console.ReadLine()
                .Split("||", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var startAmountOfFuel = int.Parse(Console.ReadLine());
            var startAmountOfAmmunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < travelRoute.Length; i++)
            {
                var cmdArgs = travelRoute[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = cmdArgs[0];
               
                if (command == "Travel")
                { 
                    var lightYears = int.Parse(cmdArgs[1]);

                    if (startAmountOfFuel < lightYears)
                    { 
                        Console.WriteLine("Mission failed.");
                        break;
                    }

                    startAmountOfFuel -= lightYears;
                    Console.WriteLine($"The spaceship travelled {lightYears} light-years.");
                }
                else if (command == "Enemy")
                {
                    var enemyArmor = int.Parse(cmdArgs[1]);
                    
                    if (startAmountOfAmmunition >= enemyArmor)
                    {
                        startAmountOfAmmunition -= enemyArmor;
                        Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
                    }
                    else
                    {
                        if (startAmountOfFuel >= (enemyArmor * 2))
                        {
                            startAmountOfFuel -= enemyArmor * 2; 
                            Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            break;
                        }
                    }
                }
                else if (command == "Repair")
                {
                    var numberOfAmmoAndFuel = int.Parse(cmdArgs[1]);

                    startAmountOfFuel += numberOfAmmoAndFuel;
                    startAmountOfAmmunition += numberOfAmmoAndFuel * 2;

                    Console.WriteLine($"Ammunitions added: {numberOfAmmoAndFuel * 2}.");
                    Console.WriteLine($"Fuel added: {numberOfAmmoAndFuel}.");
                }
                else
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    break;
                }
            }
        }
    }
}
