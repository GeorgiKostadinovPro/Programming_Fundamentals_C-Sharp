using System;
using System.Linq;

namespace _02_ArrayModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string commandLine;

            while ((commandLine = Console.ReadLine()) != "end")
            {
                string[] commands = commandLine
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string comm = commands[0];

                if (comm == "swap")
                {
                    int firstIndex = int.Parse(commands[1]);
                    int secondIndex = int.Parse(commands[2]);

                    int temp = numbers[firstIndex];
                    numbers[firstIndex] = numbers[secondIndex];
                    numbers[secondIndex] = temp;
                }
                else if (comm == "multiply")
                {
                    int firstIndex = int.Parse(commands[1]);
                    int secondIndex = int.Parse(commands[2]);

                    numbers[firstIndex] *= numbers[secondIndex];
                }
                else if (comm == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
