using System;
using System.Globalization;

namespace vending_machine
{
    static class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new Bank();
            var vendingMachine = new VendingMachine();
            var inventory = vendingMachine.Inventory;

            while (true)
            {
                Console.WriteLine("Welcome to the Vending Machine!!");
                Console.WriteLine("Choose any of the following options by typing its number:");
                Console.WriteLine("1. Buy Products");
                Console.WriteLine("2. Check balance");
                Console.WriteLine("3. Exit");

                var option = Console.ReadLine();

                if (option == "1") // Buy something
                {
                    vendingMachine.ShowAllProducts();
                    Console.WriteLine("Enter the id number of the product you would you like to buy");

                    var usersChoice = Console.ReadLine();
                    int.TryParse(usersChoice, out int number);

                    if (number > inventory.Count || number < 1)
                    {
                        Console.WriteLine("Item does not exist");
                        Console.WriteLine("---------------------");
                    }
                    else
                    {
                        var chosenItem = inventory[number - 1];
                        Console.WriteLine($"You have chosen {chosenItem.Name} for {chosenItem.Price} kr. Do you wish to pay? [yes] or [no]");

                        var answer = Console.ReadLine();
                        
                        if (answer == "yes")
                        {

                            if (bankAccount.Balance >= chosenItem.Price)
                            {
                                bankAccount.Withdraw(chosenItem.Price);
                                Console.WriteLine($"Enjoy your purchase! Your balance is now {bankAccount.Balance}");
                                break;

                            }
                            Console.WriteLine($"Sorry, your balance is too low. Your balance: {bankAccount.Balance}");
                            break;
                        }

                        if (answer == "no")
                        {
                            Console.WriteLine("No snacks this time? Ok, see you next time! Bye!");
                            break;
                        }
                    }
                }

                if (option == "2") // Check balance
                {
                    bankAccount.CheckBalance();
                    continue;
                }

                if (option == "3") // Exit without anything
                {
                    Console.WriteLine("See you next time!");
                    break;
                }
            }
        }
    }
}