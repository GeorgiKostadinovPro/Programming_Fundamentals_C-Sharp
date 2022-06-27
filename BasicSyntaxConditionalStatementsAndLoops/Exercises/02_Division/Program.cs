using System;

namespace _02_Division
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;

            if (n % 2 == 0 || n % 3 == 0 || n % 6 == 0 || n % 7 ==0 || n % 10 == 0)
            {
                if (n % 2 == 0)
                {
                    result = $"The number is divisible by 2";
                }

                if (n % 3 == 0)
                {
                    result = $"The number is divisible by 3";
                }

                if (n % 6 == 0)
                {
                    result = $"The number is divisible by 6";
                }

                if (n % 7 == 0)
                {
                    result = $"The number is divisible by 7";
                }

                if (n % 10 == 0)
                {
                    result = $"The number is divisible by 10";
                }
            }
            else 
            {
                result = "Not divisible";
            }

            Console.WriteLine(result);
        }
    }
}
