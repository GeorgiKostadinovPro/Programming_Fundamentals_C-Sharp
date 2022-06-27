using System;

namespace _09_PadawanEquipment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            decimal sabersPrice = lightsaberPrice * (decimal)(Math.Ceiling(studentsCount + studentsCount * 0.1));
            decimal robesPrice = robePrice * studentsCount;
            decimal beltsPrice = beltPrice * (studentsCount - (studentsCount / 6));
            decimal total = sabersPrice + robesPrice + beltsPrice;

            if (total <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else 
            {
                Console.WriteLine($"John will need {Math.Abs(total - money):f2}lv more.");
            }
        }
    }
}