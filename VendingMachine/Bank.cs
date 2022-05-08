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

namespace vending_machine
{
    public class Bank
    {
        public int Balance = 50;

        public int Withdraw(int amount)
        {

            if (Balance >= amount)
            {
                Balance -= amount;
                return Balance;
                
            }
            return 0;
        }
        
        public void CheckBalance()
        {
            Console.WriteLine($"Your balance is: {Balance}");
            Console.WriteLine("---------------------------");
            
        }
    }
}