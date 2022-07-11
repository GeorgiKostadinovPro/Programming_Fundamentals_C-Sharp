using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_TakeSkipRope
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<string> characters = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    int number = word[i] - '0';
                    numbers.Add(number);
                }
                else
                {
                    characters.Add(word[i].ToString());
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            int currSkipIndex = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(characters);

                int takeCount = takeList[i];
                int skipCount = skipList[i];

                temp = temp.Skip(currSkipIndex).Take(takeCount).ToList();

                result.Append(string.Join("", temp));

                currSkipIndex += takeCount + skipCount;
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
}