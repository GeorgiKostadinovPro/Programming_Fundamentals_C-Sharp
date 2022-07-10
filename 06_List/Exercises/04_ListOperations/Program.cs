using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_ListOperations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmdArgs[0];

                if (cmd == "Add")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Add(number);
                }
                else if (cmd == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (cmd == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (cmd == "Shift")
                { 
                    string condition = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);

                    if (condition == "left")
                    {
                        while (count > 0)
                        {
                            int number = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(number);
                            count--;
                        }
                    }
                    else
                    {
                        while (count > 0)
                        {
                            int number = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, number);
                            count--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}