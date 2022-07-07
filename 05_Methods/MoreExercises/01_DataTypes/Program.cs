using System;

namespace _01_DataTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string line = Console.ReadLine();

            DataTypes(type, line);
        }

        private static void DataTypes(string type, string line)
        {
            if (type == "int")
            {
                int number = int.Parse(line) * 2;
                Console.WriteLine(number);
            }
            else if (type == "real")
            {
                double number = double.Parse(line) * 1.5;
                Console.WriteLine($"{number:f2}");
            }
            else if (type == "string")
            {
                string str = "$" + line + "$";
                Console.WriteLine(str);
            }
        }
    }
}