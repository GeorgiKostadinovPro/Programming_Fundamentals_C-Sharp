using System;

namespace _01_RandomizeWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                var randomIndex = random.Next(0, words.Length);

                string a = words[randomIndex];
                string b = words[i];

                words[randomIndex] = b;
                words[i] = a;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}