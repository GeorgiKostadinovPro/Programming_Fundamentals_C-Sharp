using System;
using System.Linq;

namespace _02_TheLift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                while (lift[i] < 4 && people > 0)
                {
                    lift[i]++;
                    people--;
                }
            }

            if (people <= 0 && lift.Any(l => l < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people > 0 && !lift.Any(l => l < 4))
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people <= 0 && (lift.Count(l => l == 4) == lift.Length))
            {
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}