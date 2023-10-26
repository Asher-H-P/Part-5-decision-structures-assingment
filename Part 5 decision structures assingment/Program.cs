using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_decision_structures_assingment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            bool done = false;
            double money = 150;
            int rent = generator.Next(100, 400);
            while (!done)
            {
                Console.WriteLine("Thank you for using a BoB ATM. How may I help you?");
                Console.WriteLine("Each use costs ¢75.");
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdraw");
                Console.WriteLine("Bill Payment");
                Console.WriteLine("Account Balance");
                Console.WriteLine("Quit");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "QUIT")
                {
                    Console.WriteLine("Goodbye!");
                    done = true;
                }
                money = money - 0.75;
                if (choice == "DEPOSIT")
                {
                    Console.Write("How much would you like to deposit? ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (deposit > 0)
                    {
                        Console.WriteLine($"You now have ${money}.");
                    }
                    else if (deposit <= 0)
                    {
                        Console.WriteLine("Invalid response!");
                    }
                    else
                    {
                        Console.WriteLine("ERROR!");
                    }
                    Console.WriteLine();
                }
                else if (choice == "WITHDRAW")
                {
                    Console.Write("How much would you like to withdral? ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    if (withdraw == money)
                    {
                        Console.WriteLine($"You withdrew all of your money. You now have ${money}.");
                    }
                    else if (withdraw < money && withdraw > 0)
                    {
                        Console.WriteLine($"You withdrew ${withdraw}. You now have {money}.");
                    }
                    else if (withdraw > money || withdraw <= 0)
                    {
                        Console.WriteLine("Invalid response!");
                    }
                    else
                    {
                        Console.WriteLine("ERROR!");
                    }
                }
                else if (choice == "BILL PAYMENT")
                {
                    Console.Write($"Your rent is ${rent}. How much would you like to pay? ");
                    int payment = Convert.ToInt32(Console.ReadLine());
                    if (payment == money && payment == rent)
                    {
                        Console.WriteLine("You payed all your rent, but now you have no money.");
                    }
                    else if (payment == money && payment < rent)
                    {
                        Console.WriteLine("You have no more money and you haven't payed all your rent.");
                    }
                    Console.WriteLine();
                }
                else if (choice == "ACCOUNT BALANCE")
                {
                    Console.WriteLine($"Your account balance is ${money}.");
                    Console.WriteLine();
                    if (money <= 100 && money >= 20)
                    {
                        Console.WriteLine("You're poor.");
                    }
                    else if (money <= 19.99 && money >= 0)
                    {
                        Console.WriteLine("You're broke.");
                    }
                    else if (money < 0)
                    {
                        Console.WriteLine("You're in debt.");
                    }
                    else if (money >= 100.0000001 && money <= 500)
                    {
                        Console.WriteLine("You've got some money.");
                    }
                    else if (money < 500)
                    {
                        Console.WriteLine("You've got a lot of money.");
                    }
                    else
                    {
                        Console.WriteLine("ERROR!");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid response!");
                    Console.WriteLine();
                }
                Console.WriteLine("Do you need anything else?");
                Console.WriteLine();
                string redo = Console.ReadLine().ToUpper();
                Console.WriteLine();
                if (redo == "YES" || redo == "Y")
                {
                    Console.WriteLine("Okay.");
                    Console.WriteLine();
                }
                else if (redo == "NO" || redo == "N")
                {
                    Console.WriteLine("Goodbye.");
                    done = true;
                }
            }
        }
    }
}
