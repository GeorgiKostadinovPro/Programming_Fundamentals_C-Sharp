using System;
using System.Linq;

namespace _01_ActivationKeys
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();

            string line;
            while ((line = Console.ReadLine()) != "Generate")
            {
                string[] cmd = line
                    .Split(new string[] { ">>>" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = cmd[0];

                if (command == "Contains")
                {
                    string subString = cmd[1];

                    if (rawKey.Contains(subString))
                    {
                        Console.WriteLine($"{rawKey} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string secondCom = cmd[1];
                    int startIndex = int.Parse(cmd[2]);
                    int endIndex = int.Parse(cmd[3]);
                    int length = endIndex - startIndex;

                    if (secondCom == "Upper")
                    {
                        string firstSub = rawKey.Substring(startIndex, length);
                        string finalSub = firstSub.ToUpper();
                        rawKey = rawKey.Replace(firstSub, finalSub);
                        Console.WriteLine(rawKey);
                    }
                    else if (secondCom == "Lower")
                    {
                        string firstSub = rawKey.Substring(startIndex, length);
                        string finalSub = firstSub.ToLower();
                        rawKey = rawKey.Replace(firstSub, finalSub);
                        Console.WriteLine(rawKey);
                    }
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    int length = endIndex - startIndex;

                    rawKey = rawKey.Remove(startIndex, length);
                    Console.WriteLine(rawKey);
                }
            }

            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
