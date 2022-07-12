using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Students
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }


        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] studentInfo = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string homeTown = studentInfo[3];
                
                Student student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);
            }

            string town = Console.ReadLine();

            students = students.Where(s => s.HomeTown == town).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}