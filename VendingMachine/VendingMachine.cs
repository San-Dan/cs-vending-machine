/*
    Write a virtual vending machine where the user can buy different items.
    To buy items they need enough money.
    To get money they need to withdraw from a virtual bank.
    User should be able to see what they have bought, 
    goods available in the machine, and how much money they have.
    
    Implement all of this using an object oriented approach where the bank, 
    the vending machine, the inventory, and so on are objects that 
    interact with each other through some basic user interface.
*/
using System;
using System.Collections.Generic;

namespace vending_machine
{
    public class VendingMachine
    {
        public readonly List<Product> Inventory = new List<Product>
        {
            new Product(1, "Soda", 20),
            new Product(2, "Nuts", 10),
            new Product(3, "Candy", 15),
            new Product(4, "Sandwich", 30)

        };

        public void ShowAllProducts()
        {
            if (Inventory.Count == 0)
            {
                Console.WriteLine("No items left");
                return;
            }
            Console.WriteLine("Vending Machine Products");
            Console.WriteLine("-----------------------");

            foreach (var item in Inventory)
            {
                Console.WriteLine($"No. {item.Id}: {item.Name}, {item.Price} SEK");
            }
            Console.WriteLine("-----------------------");
        }
    }
}