using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_OrderByAge
{
    public class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] info = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);

                Person person = people.FirstOrDefault(x => x.Id == id);

                if (person != null)
                {
                    person.Name = name;
                    person.Age = age;
                    person.Id = id;
                }
                else
                {
                    person = new Person(name, id, age);
                    people.Add(person);
                }
            }

            foreach (var person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
