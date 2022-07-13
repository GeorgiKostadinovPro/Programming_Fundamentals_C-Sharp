using System;
using System.Linq;

namespace _04_Students
{
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Student student = new Student(firstName, lastName, grade);
                students[i] = student;
            }

            students = students.OrderByDescending(s => s.Grade).ToArray();

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}