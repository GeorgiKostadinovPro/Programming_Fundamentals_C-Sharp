using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OldestFamilyMember
{  
    public class Family
    {
        private List<Person> people;
        public Family()
        {
           this.people = new List<Person>();
        }

        public void AddMember(Person member)
        {
            if (!this.people.Contains(member))
            {
                this.people.Add(member);
            }
        }

        public Person GetOldestMember()
            => this.people
            .OrderByDescending(p => p.Age)
            .FirstOrDefault();
    }

    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Person oldestFamilyMember = family.GetOldestMember();
            Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
        }
    }
}