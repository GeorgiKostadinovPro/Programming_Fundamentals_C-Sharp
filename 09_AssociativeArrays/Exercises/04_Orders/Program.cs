using System;
using System.Collections.Generic;

namespace _04_Orders
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public double TotalPrice => this.Quantity * this.Price;
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "buy")
            {
                string[] productInfo = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = productInfo[0];
                double price = double.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                Product product = new Product()
                {
                    Name = name,
                    Price = price,
                    Quantity = quantity
                };

                if (!products.ContainsKey(name))
                {
                    products.Add(name, product);
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quantity;
                }
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.TotalPrice:f2}");
            }
        }
    }
}