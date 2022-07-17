using System;
using System.Collections.Generic;

namespace _06_Courses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] info = line
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = info[0];
                string student = info[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(student);
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}