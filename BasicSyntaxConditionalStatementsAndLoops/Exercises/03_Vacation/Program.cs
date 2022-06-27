using System;

namespace _03_Vacation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal peopleCount = decimal.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            decimal singlePrice = 0M;
            decimal totalExpenses = 0M;

            switch (dayOfWeek)
            {
                case "Friday":
                    switch (groupType)
                    {
                        case "Students": singlePrice = 8.45M; break;
                        case "Business": singlePrice = 10.9M; break;
                        case "Regular": singlePrice = 15M; break;
                    }
                    break;
                case "Saturday":
                    switch (groupType)
                    {
                        case "Students": singlePrice = 9.8M; break;
                        case "Business": singlePrice = 15.6M; break;
                        case "Regular": singlePrice = 20M; break;
                    }
                    break;
                case "Sunday":
                    switch (groupType)
                    {
                        case "Students": singlePrice = 10.46M; break;
                        case "Business": singlePrice = 16M; break;
                        case "Regular": singlePrice = 22.5M; break;
                    }
                    break;
            }
            totalExpenses = singlePrice * peopleCount;

            if (groupType == "Students" && peopleCount >= 30)
            {
                totalExpenses *= 0.85M;
            }
            if (groupType == "Business" && peopleCount >= 100)
            {
                totalExpenses = (peopleCount - 10) * singlePrice;
            }
            if (groupType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                totalExpenses *= 0.95M;
            }

            Console.WriteLine($"Total price: {totalExpenses:f2}");
        }
    }
}