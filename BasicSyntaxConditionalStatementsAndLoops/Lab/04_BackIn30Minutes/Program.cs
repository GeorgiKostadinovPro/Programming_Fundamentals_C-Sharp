using System;

namespace _04_BackIn30Minutes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            TimeSpan ts = new TimeSpan(hours, minutes + 30, 0);

            string result = ts.Minutes > 9 ? $"{ts.Hours}:{ts.Minutes}" : $"{ts.Hours}:0{ts.Minutes}";
            Console.WriteLine(result);
        }
    }
}
