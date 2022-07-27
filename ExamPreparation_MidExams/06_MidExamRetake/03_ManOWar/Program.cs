using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ManOWar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] pirateShipStatus = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] warshipStatus = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxHealthSection = int.Parse(Console.ReadLine());

            string command = string.Empty;

            bool pirateShipSunk = false;
            bool warshipSunk = false;

            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] info = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmd = info[0];

                if (cmd == "Fire")
                {
                    int index = int.Parse(info[1]);
                    int damage = int.Parse(info[2]);

                    if (IsValidIndex(warshipStatus, index))
                    {
                        warshipStatus[index] -= damage;

                        if (warshipStatus[index] <= 0)
                        {
                            warshipSunk = true;
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            break;
                        }
                    }
                }
                else if (cmd == "Defend")
                {
                    int startIndex = int.Parse(info[1]);
                    int endIndex = int.Parse(info[2]);
                    int damage = int.Parse(info[3]);

                    if (IsValidIndex(pirateShipStatus, startIndex)
                        && IsValidIndex(pirateShipStatus, endIndex))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShipStatus[i] -= damage;

                            if (pirateShipStatus[i] <= 0)
                            {
                                pirateShipSunk = true;
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                break;
                            }
                        }
                    }
                }
                else if (cmd == "Repair")
                {
                    int index = int.Parse(info[1]);
                    int health = int.Parse(info[2]);

                    if (IsValidIndex(pirateShipStatus, index))
                    {
                        int check = pirateShipStatus[index] + health;

                        if (check > maxHealthSection)
                        {
                            pirateShipStatus[index] += maxHealthSection - pirateShipStatus[index];
                        }
                        else
                        {
                            pirateShipStatus[index] += health;
                        }
                    }
                }
                else
                {
                    int count = 0;

                    for (int i = 0; i < pirateShipStatus.Length; i++)
                    {
                        double lowerLim = maxHealthSection * 0.2;

                        if (pirateShipStatus[i] < lowerLim)
                        {
                            count++;
                        }
                    }

                    Console.WriteLine($"{count} sections need repair.");
                }
            }

            if (pirateShipSunk == false && warshipSunk == false)
            {
                Console.WriteLine($"Pirate ship status: {pirateShipStatus.Sum()}");
                Console.WriteLine($"Warship status: {warshipStatus.Sum()}");

            }
        }

        private static bool IsValidIndex(int[] ship, int index)
        {
            return index >= 0 && index < ship.Length;
        }
    }
}