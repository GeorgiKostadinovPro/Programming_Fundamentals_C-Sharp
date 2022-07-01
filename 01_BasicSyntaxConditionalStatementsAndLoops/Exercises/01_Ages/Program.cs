using System;

namespace _01_Ages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            string result = string.Empty;

            if (age >= 0 && age <= 2)
            {
                result = "baby";
            }
            else if (age > 2 && age <= 13)
            {
                result = "child";

            }
            else if (age > 13 && age <= 19)
            {
                result = "teenager";

            }
            else if (age > 19 && age <= 65)
            {
                result = "adult";
            }
            else if (age > 65)
            {
                result = "elder";
            }

            Console.WriteLine(result);
        }
    }
}
