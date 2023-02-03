using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = {"Oranges", "Apples", "Pears", "Eggs", "Bread", "Butter"};
            LinkedList<ShoppingItem> shoppingList = new LinkedList<ShoppingItem>();
            foreach (string name in items) {
                Random random = new Random();
                ShoppingItem item = new ShoppingItem(name, (float)random.NextDouble() * 3, random.Next(1,10));
                shoppingList.AddLast(item);
            }
            foreach (ShoppingItem si in shoppingList) {
                Console.WriteLine($"Item: {si.Name:15}, Price: {si.Price}, Quantity: {si.Quantity}");
            }
        }
    }
    public class ShoppingItem {

        float _price;

        public ShoppingItem(string name, float price, int quantity) {
            Name = name;
            _price = price;
            Quantity = quantity;
        }
        public string Name {
            get;
            set;
        }

        public string Price {
            get => $"{_price:C2}";
        }

        public int Quantity {
            get;
            set;
        }
    } 
}
