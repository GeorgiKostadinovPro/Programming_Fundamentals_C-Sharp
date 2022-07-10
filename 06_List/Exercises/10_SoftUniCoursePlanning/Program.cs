using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_SoftUniCoursePlanning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> inititalLessons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "course start")
            {
                var commands = line
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                string command = commands[0];
                string lessonTitle = commands[1];
                string exercise = $"{lessonTitle}-Exercise";

                if (command == "Add")
                {
                    if (!Check(inititalLessons, lessonTitle))
                    {
                        inititalLessons.Add(lessonTitle);
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commands[2]);

                    if (!Check(inititalLessons, lessonTitle))
                    {
                        inititalLessons.Insert(index, lessonTitle);
                    }
                }
                else if (command == "Remove")
                {
                    if (Check(inititalLessons, lessonTitle))
                    {
                        inititalLessons.Remove(lessonTitle);

                        if (Check(inititalLessons, exercise))
                        {
                            inititalLessons.Remove(exercise);
                        }
                    }
                }
                else if (command == "Swap")
                {
                    string secondLesson = commands[2];
                    string secondLessonExerise = $"{secondLesson}-Exercise";

                    if (Check(inititalLessons, lessonTitle) && Check(inititalLessons, secondLesson))
                    {
                        int firstIndex = inititalLessons.IndexOf(lessonTitle);
                        int secondIndex = inititalLessons.IndexOf(secondLesson);

                        string temp = inititalLessons[firstIndex];
                        inititalLessons[firstIndex] = inititalLessons[secondIndex];
                        inititalLessons[secondIndex] = temp;

                        if (Check(inititalLessons, exercise))
                        {
                            inititalLessons.Remove(exercise);
                            inititalLessons.Insert(secondIndex + 1, exercise);
                        }

                        if (Check(inititalLessons, secondLessonExerise))
                        {
                            inititalLessons.Remove(secondLessonExerise);
                            inititalLessons.Insert(firstIndex + 1, secondLessonExerise);
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    if (Check(inititalLessons, lessonTitle))
                    {
                        if (!Check(inititalLessons, exercise))
                        {
                            int indexOfLesson = inititalLessons.IndexOf(lessonTitle);

                            inititalLessons.Insert(indexOfLesson + 1, exercise);
                        }
                    }
                    else
                    {
                        inititalLessons.Add(lessonTitle);
                        inititalLessons.Add(exercise);
                    }
                }
            }

            for (int i = 0; i < inititalLessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{inititalLessons[i]}");
            }
        }

        private static bool Check(List<string> inititalLessons, string lessonTitle)
        {
            return inititalLessons.Contains(lessonTitle);
        }
    }
}