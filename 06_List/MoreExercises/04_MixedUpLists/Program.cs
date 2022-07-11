using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MixedUpLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> mixedList = new List<int>();

            while (firstNumbers.Count > 0 && secondNumbers.Count > 0)
            {
                int firstElement = firstNumbers[0];
                int secondElement = secondNumbers[secondNumbers.Count - 1];

                firstNumbers.RemoveAt(0);
                secondNumbers.RemoveAt(secondNumbers.Count - 1);

                mixedList.Add(firstElement);
                mixedList.Add(secondElement);
            }

            List<int> rangeOfElementsNeededToPrint = firstNumbers.Count > 0 ? firstNumbers : secondNumbers;

            int start = rangeOfElementsNeededToPrint[0] < rangeOfElementsNeededToPrint[1] 
                ? rangeOfElementsNeededToPrint[0] : rangeOfElementsNeededToPrint[1];

            int end = start == rangeOfElementsNeededToPrint[0]
                ? rangeOfElementsNeededToPrint[1] : rangeOfElementsNeededToPrint[0];
                
            mixedList = mixedList
                .Where(x => x > start && x < end)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(" ", mixedList));
        }
    }
}