using System;

namespace _09_GreaterOfTwoValues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();

            Console.WriteLine(GreaterValue(inputName, firstName, secondName));
        }

        private static string GreaterValue(string inputName, string name1, string name2)
        {
            string result = string.Empty;

            switch (inputName)
            {
                case "int":
                    result = (Math.Max(int.Parse(name1), int.Parse(name2))).ToString();
                    break;
                case "char":
                case "string":
                    return name1[0] > name2[0] ? name1 : name2;
                default:
                    break;
            }

            return result;
        }
    }
}
