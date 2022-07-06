using System;
using System.Linq;

namespace _11_ArrayManipulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = line.Split(' ');

                if (cmdArgs[0] == "exchange")
                {
                    int positionToExchange = int.Parse(cmdArgs[1]);

                    if (positionToExchange >= 0 && positionToExchange < numbers.Length)
                    {

                        Exchange(numbers, positionToExchange);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                }
                else if (cmdArgs[0] == "max")
                {
                    string typeNum = cmdArgs[1];
                    int index = -1;

                    if (typeNum == "odd")
                    {
                        index = MaxEvenOrOddIndex(numbers, 1);
                        Console.WriteLine(index);
                    }
                    else
                    {
                        index = MaxEvenOrOddIndex(numbers, 0);
                        Console.WriteLine(index);
                    }

                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                }
                else if (cmdArgs[0] == "min")
                {
                    string typeNum = cmdArgs[1];
                    int index = -1;

                    if (typeNum == "odd")
                    {
                        index = MinEvenOrOddIndex(numbers, 1);

                    }
                    else
                    {
                        index = MinEvenOrOddIndex(numbers, 0);

                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }

                    Console.WriteLine(index);
                }
                else if (cmdArgs[0] == "first")
                {
                    int count = int.Parse(cmdArgs[1]);

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeNum = cmdArgs[2];
                    int[] result = new int[0];

                    if (typeNum == "odd")
                    {
                        result = FirstEvenOrOddElements(numbers, count, 1);
                    }
                    else if (typeNum == "even")
                    {
                        result = FirstEvenOrOddElements(numbers, count, 0);
                    }

                    Console.WriteLine("[" + string.Join(", ", result) + "]");
                }
                else if (cmdArgs[0] == "last")
                {
                    int count = int.Parse(cmdArgs[1]);

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    string typeNum = cmdArgs[2];
                    int[] result = new int[0];

                    if (typeNum == "odd")
                    {
                        result = LastEvenOrOddElements(numbers, count, 1);
                    }
                    else if (typeNum == "even")
                    {
                        result = LastEvenOrOddElements(numbers, count, 0);
                    }

                    Console.WriteLine("[" + string.Join(", ", result) + "]");
                }
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static int[] LastEvenOrOddElements(int[] arr, int neededCount, int divisibleResult)
        {
            int[] resultArr = new int[neededCount];
            int currCounter = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == divisibleResult && currCounter < neededCount)
                {
                    resultArr[currCounter] = arr[i];
                    currCounter++;
                }
            }

            if (currCounter >= neededCount)
            {
                return resultArr.Reverse().ToArray();
            }
            else
            {
                int[] tempArr = new int[currCounter];
                Array.Copy(resultArr, tempArr, currCounter);
                return tempArr.Reverse().ToArray();
            }
        }

        public static void Exchange(int[] arr, int position)
        {
            for (int i = 0; i <= position; i++)
            {
                int firstNum = arr[0];

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[arr.Length - 1] = firstNum;
            }

        }

        public static int MaxEvenOrOddIndex(int[] arr, int divisonResult)
        {
            int maxNum = int.MinValue;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= maxNum && arr[i] % 2 == divisonResult)
                {
                    maxNum = arr[i];
                    index = i;
                }
            }
            return index;
        }

        public static int MinEvenOrOddIndex(int[] arr, int divisonResult)
        {
            int minNum = int.MaxValue;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= minNum && arr[i] % 2 == divisonResult)
                {
                    minNum = arr[i];
                    index = i;
                }
            }
            return index;
        }

        public static int[] FirstEvenOrOddElements(int[] arr, int neededCount, int divisibleResult)
        {
            int[] resultArr = new int[neededCount];
            int currCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == divisibleResult && currCounter < neededCount)
                {
                    resultArr[currCounter] = arr[i];
                    currCounter++;
                }
            }

            if (currCounter >= neededCount)
            {
                return resultArr;
            }
            else
            {
                int[] tempArr = new int[currCounter];
                Array.Copy(resultArr, tempArr, currCounter);
                return tempArr;
            }
        }
    }
}