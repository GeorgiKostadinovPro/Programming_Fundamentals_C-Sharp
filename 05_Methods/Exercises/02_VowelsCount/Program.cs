using System;

namespace _02_VowelsCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            GetVowelsCountInString(str);
        }

        private static void GetVowelsCountInString(string str)
        {
            int vowelsCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' 
                    || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'
                    || str[i] == 'A' || str[i] == 'E' 
                    || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);
        }
    }
}