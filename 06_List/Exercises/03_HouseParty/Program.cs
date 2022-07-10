using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_HouseParty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guestsList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string guestName = cmdArgs[0];

                if (cmdArgs.Length == 3)
                {
                    if (guestsList.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                        continue;
                    }

                    guestsList.Add(guestName);
                }
                else 
                {
                    if (!guestsList.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                        continue;
                    }

                    guestsList.Remove(guestName);
                }
            }

            guestsList.ForEach(Console.WriteLine);
        }
    }
}