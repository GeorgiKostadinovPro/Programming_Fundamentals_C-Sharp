using System;
using System.Text;

namespace _02_RepeatStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < strings.Length; i++)
            {
                string currentElement = strings[i];
                int repetitionCount = currentElement.Length;

                for (int j = 0; j < repetitionCount; j++)
                {
                    sb.Append(currentElement);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}