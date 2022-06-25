using System;

namespace SoftUniFundamentalsExam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int biscuitsPerDayPerWorker = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int competetingFactoryProduction = int.Parse(Console.ReadLine());

            int production = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    int currProduction = biscuitsPerDayPerWorker * workersCount;
                    int percentageToRemove = (int)((biscuitsPerDayPerWorker * workersCount) * 0.25);
                    currProduction -= percentageToRemove;
                    production += currProduction;
                }
                else
                {
                    production += (int)(biscuitsPerDayPerWorker * workersCount);
                }
            }
                
            double difference = production - competetingFactoryProduction;
            double percentage = Math.Abs(Math.Round(difference / competetingFactoryProduction * 100, 2));

            Console.WriteLine($"You have produced {production} biscuits for the past month.");

            if (difference > 0)
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}
