using System;

namespace _01_WorldTour
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Travel")
            {
                string[] cmdArgs = line
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmdArgs[0];

                if (cmd == "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string subStr = cmdArgs[2];

                    if (IsIndexValid(str, index))
                    {
                        str = str.Insert(index, subStr);
                    }

                    Console.WriteLine(str);
                }
                else if (cmd == "Remove Stop")
                {
                    int start = int.Parse(cmdArgs[1]);
                    int end = int.Parse(cmdArgs[2]);

                    if (IsIndexValid(str, start) && IsIndexValid(str, end))
                    {
                        str = str.Remove(start, end - start + 1);
                    }

                    Console.WriteLine(str);
                }
                else if (cmd == "Switch")
                {
                    string old = cmdArgs[1];
                    string newStr = cmdArgs[2];

                    if (str.Contains(old))
                    {
                        str = str.Replace(old, newStr);
                    }

                    Console.WriteLine(str);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {str}");
        }

        private static bool IsIndexValid(string str, int index)
        {
            return index >= 0 && index < str.Length;
        }
    }
}