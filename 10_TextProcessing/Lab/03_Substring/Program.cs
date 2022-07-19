using System;

namespace _03_Substring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstStr = Console.ReadLine();  
            string secondStr = Console.ReadLine();

            while (secondStr.Contains(firstStr))
            {
               secondStr = secondStr.Replace(firstStr, string.Empty);
            }

            Console.WriteLine(secondStr);
        }
    }
}