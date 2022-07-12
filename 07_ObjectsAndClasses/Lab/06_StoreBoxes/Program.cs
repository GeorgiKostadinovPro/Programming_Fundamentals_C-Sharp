using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_StoreBoxes
{
    public class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal Price => this.Item.Price * this.ItemQuantity;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            { 
                string[] boxInfo = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                decimal itemPrice = decimal.Parse(boxInfo[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);

                boxes.Add(box);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var box in boxes.OrderByDescending(b => b.Price))
            {
                sb.AppendLine(box.SerialNumber);
                sb.AppendLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                sb.AppendLine($"-- ${box.Price:f2}");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}