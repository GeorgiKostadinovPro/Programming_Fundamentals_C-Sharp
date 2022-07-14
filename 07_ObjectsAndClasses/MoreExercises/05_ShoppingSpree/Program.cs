using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_ShoppingSpree
{
    public class Product
    {
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name { get; set; }

        public decimal Cost { get; set; }
    }

    public class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;

            this.Products = new List<Product>();
        }
        public string Name { get; set; }

        public decimal Money { get; set; }

        public List<Product> Products { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInfo = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            string[] productsInfo = Console.ReadLine()
               .Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] infoForPerson = peopleInfo[i]
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);

                string name = infoForPerson[0];
                decimal money = decimal.Parse(infoForPerson[1]);

                Person person = new Person(name, money);
                people.Add(person);
            }

            for (int i = 0; i < productsInfo.Length; i++)
            {
                string[] infoForProduct = productsInfo[i]
                .Split("=", StringSplitOptions.RemoveEmptyEntries);

                string name = infoForProduct[0];
                decimal cost = decimal.Parse(infoForProduct[1]);

                Product product = new Product(name, cost);
                products.Add(product);
            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "END")
            {
                string[] cmds = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string personName = cmds[0];
                string productName = cmds[1];

                Person person = people.FirstOrDefault(p => p.Name == personName);

                if (person != null)
                {
                    Product product = products.FirstOrDefault(p => p.Name == productName);

                    if (product != null)
                    {
                        if (person.Money >= product.Cost)
                        {
                            Console.WriteLine($"{person.Name} bought {product.Name}");
                            person.Products.Add(product);
                            person.Money -= product.Cost;
                        }
                        else
                        {
                            Console.WriteLine($"{person.Name} can't afford {product.Name}");
                        }
                    }
                }
            }

            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(p => p.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
