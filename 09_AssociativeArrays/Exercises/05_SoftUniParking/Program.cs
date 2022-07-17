using System;
using System.Collections.Generic;

namespace _05_SoftUniParking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmd = commands[0];
                string username = commands[1];

                if (cmd == "register")
                {
                    string number = commands[2];

                    if (!parking.ContainsKey(username))
                    {
                        parking.Add(username, number);
                        Console.WriteLine($"{username} registered {number} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {number}");
                    }
                }
                else
                {
                    if (parking.ContainsKey(username))
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var slot in parking)
            {
                Console.WriteLine($"{slot.Key} => {slot.Value}");
            }
        }
    }
}