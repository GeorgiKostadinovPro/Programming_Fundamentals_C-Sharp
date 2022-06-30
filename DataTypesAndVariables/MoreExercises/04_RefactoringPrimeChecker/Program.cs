using System;

namespace _04_RefactoringPrimeChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            for (int number = 2; number <= numbers; number++)
            {
                bool isPrime = true;

                for (int j = 2; j < number; j++)
                {
                    if (number % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                string prime = isPrime.ToString().Substring(0, 1).ToLower() + isPrime.ToString().Substring(1);

                Console.WriteLine("{0} -> {1}", number, prime);
            }
        }
    }
}