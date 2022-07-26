using System;

namespace _01_SoftUniReception
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int SecondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            int answerPerHour = firstEmployee + SecondEmployee + thirdEmployee;

            int hours = 0;

            while (students > 0)
            {
                hours++;

                if (hours % 4 == 0)
                {
                    continue;
                }

                students -= answerPerHour;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}