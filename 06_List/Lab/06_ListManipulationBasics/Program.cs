using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ListManipulationBasics
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

            while ((line = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmdArgs[0];

                int number = int.Parse(cmdArgs[1]);

                if (cmd == "Add")
                {
                    numbers.Add(number);
                }
                else if (cmd == "Remove")
                {
                    numbers.Remove(number);
                }
                else if (cmd == "RemoveAt")
                {
                    numbers.RemoveAt(number);
                }
                else if (cmd == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, number);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}