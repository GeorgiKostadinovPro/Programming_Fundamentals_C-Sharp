using System;

namespace _02_Grades
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            string result = NumberSign(grade);
            Console.WriteLine(result);
        }

        private static string NumberSign(double grade)
        {
            if (grade >= 5.5 && grade <= 6)
            {
                return "Excellent";
            }
            else if (grade >= 4.5 && grade < 5.5)
            {
                return "Very good";
            }
            else if (grade >= 3.5 && grade < 4.5)
            {
                return "Good";
            }
            else if (grade >= 3 && grade < 3.5)
            {
                return "Poor";
            }

            return "Fail";
        }
    }
}
