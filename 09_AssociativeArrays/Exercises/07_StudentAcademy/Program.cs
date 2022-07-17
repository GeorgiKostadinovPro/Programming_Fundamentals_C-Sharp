using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_StudentAcademy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double avgGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                }

                students[student].Add(avgGrade);
            }

            foreach (var student in students.Where(s => s.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}