using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ChangeList
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
                int element = int.Parse(cmdArgs[1]);

                if (cmd == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else 
                { 
                    int position = int.Parse(cmdArgs[2]);
                    numbers.Insert(position, element);
                } 
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}