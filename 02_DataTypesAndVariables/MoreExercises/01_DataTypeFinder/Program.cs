using System;

namespace _01_DataTypeFinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line  != "End")
            {
                string result = string.Empty;
                int intResult;
                float doubleResult;
                char charResult;
                bool boolResult;

                if (int.TryParse(line, out intResult))
                {
                    result = $"{line} is integer type";
                }
                else if (float.TryParse(line, out doubleResult))
                {
                    result = $"{line} is floating point type";
                }
                else if (char.TryParse(line, out charResult))
                {
                    result = $"{line} is character type";
                }
                else if (bool.TryParse(line, out boolResult))
                {
                    result = $"{line} is boolean type";
                }
                else
                {
                    result = $"{line} is string type";
                }

                Console.WriteLine(result);
                line = Console.ReadLine();
            }
        }
    }
}
