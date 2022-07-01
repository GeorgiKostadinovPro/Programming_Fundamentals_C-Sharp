using System;

namespace _10_RageExpenses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int lostGamescount = int.Parse(Console.ReadLine());
            decimal headSetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keybordPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int headSetCount = 0;
            int mouseCount = 0;
            int keybordCount = 0;
            int displayCount = 0;

            int saveKCount = 0;

            for (int i = 1; i <= lostGamescount; i++)
            {
                if (i % 2 == 0 && i % 3 != 0)
                {
                    headSetCount++;
                }
                else if (i % 3 == 0 && i % 2 != 0)
                {
                    mouseCount++;
                }
                else if (i % 3 == 0 && i % 2 == 0)
                {
                    headSetCount++;
                    mouseCount++;
                    keybordCount++;
                    saveKCount++;
                }

                if (keybordCount != 0 && keybordCount % 2 == 0)
                {
                    keybordCount = 0;
                    displayCount++;
                }
            }

            decimal total = (headSetPrice * headSetCount) + (mousePrice * mouseCount) + (keybordPrice * saveKCount) + (displayPrice * displayCount);

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}