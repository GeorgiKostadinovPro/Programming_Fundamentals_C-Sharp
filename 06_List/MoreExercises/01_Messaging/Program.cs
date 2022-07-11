using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Messaging
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder(str);

            string message = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currElement = numbers[i];
                int currElementSum = 0;

                while (currElement != 0)
                {
                    currElementSum += currElement % 10;
                    currElement /= 10;
                }

                char letter = '\u0000';

                if (currElementSum >= str.Length)
                {
                    currElementSum -= str.Length;
                    letter = sb[currElementSum];
                }
                else 
                { 
                    letter = sb[currElementSum];   
                }
                
                sb.Remove(currElementSum, 1);
                message += letter;
            }

            Console.WriteLine(message);
        }
    }
}