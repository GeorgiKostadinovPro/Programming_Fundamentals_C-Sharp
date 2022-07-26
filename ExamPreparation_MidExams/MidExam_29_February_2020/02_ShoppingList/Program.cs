using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ShoppingList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string line;

            while ((line = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commands = line.Split(' ').ToArray();
                string command = commands[0];
                string item = commands[1];

                if (command == "Urgent")
                {
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }

                }
                else if (command == "Unnecessary")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    string newItem = commands[2];

                    if (groceries.Contains(item))
                    {
                        int index = groceries.IndexOf(item);
                        groceries.RemoveAt(index);
                        groceries.Insert(index, newItem);
                    }
                }
                else if (command == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}