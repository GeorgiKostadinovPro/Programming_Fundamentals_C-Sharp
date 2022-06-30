using System;

namespace _01_StringGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Done")
            {
                string[] commandArgs = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];

                if (command == "Change")
                {
                    string character = commandArgs[1];
                    string replacement = commandArgs[2];

                    str = str.Replace(character, replacement);
                    Console.WriteLine(str);
                }
                else if (command == "Includes")
                {
                    string subStr = commandArgs[1];

                    if (str.Contains(subStr))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "End")
                {
                    string subStr = commandArgs[1];

                    if (str.EndsWith(subStr))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Uppercase")
                {
                    str = str.ToUpper();
                    Console.WriteLine(str);
                }
                else if (command == "FindIndex")
                {
                    string character = commandArgs[1];

                    int index = str.IndexOf(character);
                    Console.WriteLine(index);
                }
                else if (command == "Cut")
                {
                    int startIdx = int.Parse(commandArgs[1]);
                    int count = int.Parse(commandArgs[2]);

                    string subStr = str.Substring(startIdx, count);

                    str = subStr;
                    Console.WriteLine(str);
                }
            }
        }
    }
}