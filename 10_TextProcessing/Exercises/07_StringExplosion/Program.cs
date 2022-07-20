using System;

namespace _07_StringExplosion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int bomb = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (bomb > 0 && str[i] != '>')
                {
                    str = str.Remove(i, 1);
                    bomb--;
                    i--;
                }
                else if (str[i] == '>')
                {
                    bomb += str[i + 1] - '0';
                }
            }

            Console.WriteLine(str);
        }
    }
}