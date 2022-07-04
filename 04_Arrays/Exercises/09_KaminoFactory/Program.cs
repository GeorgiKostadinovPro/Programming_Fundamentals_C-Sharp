using System;
using System.Linq;

namespace _09_KaminoFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;

            int length = int.Parse(Console.ReadLine());
            int[] bestSequence = new int[length];

            int bestLength = int.MinValue;
            int bestSequenceIndex = int.MinValue;
            int bestSequenceSum = int.MinValue;

            int lssStart = -1;
            int index = 1;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] data = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentLength = int.MinValue, currentIndex = int.MinValue, currentSubLength = 0, currentSubIndex = 0;
                bool isOne = false;

                for (int i = 0; i < length; i++)
                {
                    if (data[i] == 1 && isOne)
                    {
                        currentSubLength++;
                    }
                    else if (data[i] == 1)
                    {
                        isOne = true;
                        currentSubIndex = i;
                        currentSubLength = 1;
                    }
                    else if (data[i] == 0 && isOne)
                    {
                        if (currentSubLength > currentLength)
                        {
                            currentLength = currentSubLength;
                            currentIndex = currentSubIndex;
                        }
                        isOne = false;
                        currentSubLength = 0;
                        currentSubIndex = 0;
                    }
                }

                if (isOne)
                {
                    if (currentSubLength > currentLength)
                    {
                        currentLength = currentSubLength;
                        currentIndex = currentSubIndex;
                    }
                }

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestSequenceIndex = currentIndex;
                    bestSequenceSum = data.Sum();
                    bestSequence = data;
                    lssStart = index;
                }
                else if (currentLength == bestLength)
                {
                    if (currentIndex < bestSequenceIndex)
                    {
                        bestLength = currentLength;
                        bestSequenceIndex = currentIndex;
                        bestSequenceSum = data.Sum();
                        bestSequence = data;
                        lssStart = index;
                    }
                    else if (currentIndex == bestSequenceIndex)
                    {
                        if (data.Sum() > bestSequenceSum)
                        {
                            bestLength = currentLength;
                            bestSequenceIndex = currentIndex;
                            bestSequenceSum = data.Sum();
                            bestSequence = data;
                            lssStart = index;
                        }
                    }
                }

                index++;
            }

            Console.WriteLine($"Best DNA sample {lssStart} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}