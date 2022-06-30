using System;
using System.Linq;

namespace _02_SpaceTravel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] travelRoute = Console.ReadLine()
                .Split("||", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int startAmountOfFuel = int.Parse(Console.ReadLine());
            int startAmountOfAmmunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < travelRoute.Length; i++)
            {
                string[] cmdArgs = travelRoute[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = cmdArgs[0];

                if (command == "Travel")
                {
                    int lightYears = int.Parse(cmdArgs[1]);

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
                    int enemyArmor = int.Parse(cmdArgs[1]);

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
                    int numberOfAmmoAndFuel = int.Parse(cmdArgs[1]);

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