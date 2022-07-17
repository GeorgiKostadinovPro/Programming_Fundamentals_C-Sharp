using System;
using System.Collections.Generic;

namespace _01_CountCharsInAString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    char s = str[i][j];

                    if (!map.ContainsKey(s))
                    {
                        map.Add(s, 0);
                    }

                    map[s]++;
                }
            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}