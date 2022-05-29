using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Store_Boxes
{
    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box(string serialNumber, string itemName, uint itemQuantity, decimal itemPrice)
        {
            SerialNumber = serialNumber;
            Item = new Item(itemName, itemPrice);
            ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public uint ItemQuantity { get; set; }
        public decimal PriceForBox
        {
            get
            {
                return ItemQuantity * Item.Price;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string serialNumber = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
                string itemName = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                uint itemQuantity = uint.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);
                decimal itemPrice = decimal.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[3]);

                Box newBox = new Box(serialNumber, itemName, itemQuantity, itemPrice);

                boxes.Add(newBox);

                command = Console.ReadLine();
            }

            List<Box> soredBoxes = boxes.OrderByDescending(box => box.PriceForBox).ToList();

            foreach (Box box in soredBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }
}
