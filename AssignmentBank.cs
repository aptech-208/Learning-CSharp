using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_
{
    internal class AssignmentBank
    {
        public void Assignment()
        {
              decimal balance = 100000;
        int choice;
        decimal amount;

        Console.WriteLine("================================");
        Console.WriteLine("       BANK ACCOUNT SYSTEM");
        Console.WriteLine("================================");

        Console.WriteLine("Total Balance: " + balance);

        Console.WriteLine("\n1. Debit (Withdraw Money)");
        Console.WriteLine("2. Credit (Add Money)");

        Console.Write("\nEnter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter amount to withdraw: ");
            amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > 0 && amount <= balance)
            {
                balance = balance - amount;

                Console.WriteLine("\nAmount Withdrawn Successfully!");
                Console.WriteLine("Remaining Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Invalid amount or insufficient balance!");
                Console.WriteLine("Current Balance: " + balance);
            }
        }
        else if (choice == 2)
        {
            Console.Write("Enter amount to deposit: ");
            amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > 0)
            {
                balance = balance + amount;

                Console.WriteLine("\nAmount Deposited Successfully!");
                Console.WriteLine("Remaining Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Please enter a valid amount!");
                Console.WriteLine("Current Balance: " + balance);
            }
        }
        else
        {
            Console.WriteLine("Invalid Choice!");
        }

        Console.WriteLine("\nThank you for using our bank!");
        Console.ReadKey();
        }
    }
}
