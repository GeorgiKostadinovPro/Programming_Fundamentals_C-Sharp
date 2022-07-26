using System;

namespace _01_CounterStrike
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            bool end = false;
            int wins = 0;

            while (initialEnergy >= 0)
            {
                string line = Console.ReadLine();

                if (line == "End of battle")
                {
                    break;
                }

                int distance = int.Parse(line);

                if (distance > initialEnergy)
                {
                    end = true;
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {initialEnergy} energy");
                    break;
                }

                initialEnergy -= distance;
                wins++;

                if (wins % 3 == 0)
                {
                    initialEnergy += wins;
                }
            }

            if (!end)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {initialEnergy}");
            }
        }
    }
}
