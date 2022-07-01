using System;

namespace _05_SpecialNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            
            for (int i = 1; i <= n; i++)
            {
                string number = i.ToString();
                int sum = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    sum += number[j] - '0';
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{number} -> True");
                }
                else 
                {
                    Console.WriteLine($"{number} -> False");
                }
            }
        }
    }
}
