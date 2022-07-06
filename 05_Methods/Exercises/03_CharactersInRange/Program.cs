using System;

namespace _03_CharactersInRange
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            GetCharactersInRange(start, end);
        }

        private static void GetCharactersInRange(char start, char end)
        {
            if ((int)start > (int)end)
            {
                char temp = start;
                start = end;
                end = temp;
            }

            for (int i = start + 1; i < end; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }
    }
}