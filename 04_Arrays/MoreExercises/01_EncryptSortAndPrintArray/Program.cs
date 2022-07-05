using System;
using System.Linq;

namespace _01_EncryptSortAndPrintArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                int strSum = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == 'a' || str[j] == 'e'
                        || str[j] == 'i' || str[j] == 'o' || str[j] == 'u'
                        || str[j] == 'A' || str[j] == 'E'
                        || str[j] == 'I' || str[j] == 'O' || str[j] == 'U')
                    {
                        strSum += (int)str[j] * str.Length;
                    }
                    else 
                    { 
                        strSum += (int)str[j] / str.Length;
                    }
                }

                result[i] = strSum;
            }

            result = result.OrderBy(e => e).ToArray();

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
