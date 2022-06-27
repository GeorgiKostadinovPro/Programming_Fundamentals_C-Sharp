using System;

namespace _06_StrongNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < n.Length; i++)
            {
                int digit = n[i] - '0';
                int digitFactoriel = Factoriel(digit);
                sum += digitFactoriel;
            }

            if (sum == int.Parse(n))
            {
                Console.WriteLine("yes");
            }
            else 
            {
                Console.WriteLine("no");
            }
        }

        private static int Factoriel(int n)
        {
            if (n < 1)
            {
                return 1;
            }

            return n * Factoriel(n - 1);
        }
    }
}