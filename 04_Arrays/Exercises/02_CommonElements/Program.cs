using System;

namespace _02_CommonElements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] second = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {
                    if (second[i] == first[j])
                    {
                        Console.Write(second[i] + " ");
                    }
                }
            }
        }
    }
}
