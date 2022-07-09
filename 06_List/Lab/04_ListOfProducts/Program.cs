using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_ListOfProducts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products = products.OrderBy(p => p).ToList();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }    
        }
    }
}