using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_ListManipulationAdvanced
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries) 
                .Select(int.Parse)
                .ToList();

            bool isChanged = false;

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmdArgs[0];

                if (cmd == "Add")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Add(number);
                    isChanged = true;
                }
                else if (cmd == "Remove")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Remove(number);
                    isChanged = true;
                }
                else if (cmd == "RemoveAt")
                {
                    int index = int.Parse(cmdArgs[1]);
                    numbers.RemoveAt(index);
                    isChanged = true;
                }
                else if (cmd == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, number);
                    isChanged = true;
                }
                else if (cmd == "Contains")
                {
                    int number = int.Parse(cmdArgs[1]);

                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (cmd == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (cmd== "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (cmd == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (cmd == "Filter")
                {
                    string condition = cmdArgs[1];
                    int numberToCheck = int.Parse(cmdArgs[2]);

                    string result = string.Empty;

                    if (condition == "<")
                    {
                        result = string.Join(" ", numbers.Where(x => x < numberToCheck));
                    }
                    else if (condition == ">")
                    {
                        result = string.Join(" ", numbers.Where(x => x > numberToCheck));
                    }
                    else if (condition == ">=")
                    {
                        result = string.Join(" ", numbers.Where(x => x >= numberToCheck));
                    }
                    else
                    {
                        result = string.Join(" ", numbers.Where(x => x <= numberToCheck));
                    }

                    Console.WriteLine(result);
                }
            }

            if (isChanged)
            {
               Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}