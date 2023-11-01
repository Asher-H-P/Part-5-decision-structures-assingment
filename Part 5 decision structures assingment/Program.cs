using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_decision_structures_assingment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Bank(generator.Next(100, 401));
            Console.WriteLine();
            Console.WriteLine();
            Parking(generator.Next(1, 21));
            Console.WriteLine();
            Console.WriteLine();
            Hurricane();
            Console.ReadLine();
        }
        public static void Bank(double rent)
        {
            bool done = false;
            double money = 150.75;
            while (!done)
            {
                Console.WriteLine("Thank you for using a BoB ATM. How may I help you?");
                Console.WriteLine("Each use costs ¢75.");
                Console.WriteLine("Deposit (D)");
                Console.WriteLine("Withdraw (W)");
                Console.WriteLine("Bill Payment (BP)");
                Console.WriteLine("Account Balance (AB)");
                string choice = Console.ReadLine().ToUpper();
                Console.WriteLine();
                money = money - 0.75;


                //DDDDDDDDDDDDDDDDDDDDDDDDDDD DONE
                if (choice == "DEPOSIT" || choice == "D")
                {
                    Console.Write("How much would you like to deposit? ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    if (deposit > 0 && deposit < 10000)
                    {
                        money = money + deposit;
                        Console.WriteLine($"You now have ${money}.");
                    }
                    else if (deposit <= 0)
                    {
                        Console.WriteLine("Invalid response!");
                    }
                    else if (deposit >= 10000)
                    {
                        money = money + deposit;
                        Console.WriteLine($"You now have ${money}.");
                        Console.WriteLine("Suspicious bank activity detected.");
                        Console.WriteLine("The authorities are now tracking you.");
                    }
                    else
                    {
                        Console.WriteLine("ERROR!");
                    }
                    Console.WriteLine();
                }
                //DDDDDDDDDDDDDDDDDDDDDDDDDDD DONE



                //WWWWWWWWWWWWWWWWWWWWWWWWWWW DONE
                else if (choice == "WITHDRAW" || choice == "W")
                {
                    Console.Write("How much would you like to withdraw? ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    if (withdraw == money)
                    {
                        money = 0;
                        Console.WriteLine($"You withdrew all of your money. You now have ${money}.");
                    }
                    else if (withdraw < money && withdraw > 0)
                    {
                        money = money - withdraw;
                        Console.WriteLine($"You withdrew ${withdraw}. You now have ${money}.");
                    }
                    else if (withdraw > money || withdraw <= 0)
                    {
                        Console.WriteLine("Invalid response!");
                    }
                    else
                    {
                        Console.WriteLine("ERROR!");
                    }
                    Console.WriteLine();
                }
                //WWWWWWWWWWWWWWWWWWWWWWWWWWW DONE



                //BBBBBBBBBBBBBBBBBBBBBBBBBBB DONE
                else if (choice == "BILL PAYMENT" || choice == "BP")
                {
                    if (rent > 0)
                    {
                        Console.Write($"Your rent is ${rent}. How much would you like to pay? ");
                        double payment = Convert.ToDouble(Console.ReadLine());
                        if (payment <= 0)
                        {
                            Console.WriteLine("Invalid response!");
                        }
                        else if (payment == money && payment == rent)
                        {
                            money = 0;
                            rent = 0;
                            Console.WriteLine("You payed all your rent, but now you have no money.");
                        }
                        else if (payment == money && payment < rent)
                        {
                            rent = rent - money;
                            money = 0;
                            Console.WriteLine("You have no more money and you haven't payed all your rent.");
                        }
                        else if (payment > money)
                        {
                            Console.WriteLine($"You don't have enough. I'll remove ${money} from ${rent}.");
                            if (rent > money && money > 0)
                            {
                                rent = rent - money;
                                money = 0;
                                Console.WriteLine($"You still need to pay ${rent}, & you have no money.");
                            }
                            else if (rent < money)
                            {
                                money = money - rent;
                                rent = 0;
                                Console.WriteLine("You payed all your rent, & you still have ${money}.");
                            }
                            else if (rent > money && money <= 0)
                            {
                                Console.WriteLine("You're too poor to pay any rent.");
                            }
                            else if (rent == money)
                            {
                                rent = 0;
                                money = 0;
                                Console.WriteLine("You payed all your rent, but now you have no money.");
                            }
                        }
                        else if (payment < money && payment >= rent)
                        {
                            payment = payment - rent;
                            money = money - rent;
                            rent = 0;
                            Console.WriteLine($"You payed all your rent, and you still have ${money}.");
                        }
                        else if (payment < money && payment < rent)
                        {
                            rent = rent - payment;
                            money = money - payment;
                            Console.WriteLine($"You still need to pay ${rent} in rent, and you still have ${money}.");
                        }
                    }
                    else if (rent <= 0)
                    {
                        Console.WriteLine("You have no rent to pay.");
                    }
                    Console.WriteLine();
                }
                //BBBBBBBBBBBBBBBBBBBBBBBBBBB DONE



                //AAAAAAAAAAAAAAAAAAAAAAAAAAA DONE
                else if (choice == "ACCOUNT BALANCE" || choice == "AB")
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
                    else if (money >= 100.001 && money <= 500)
                    {
                        Console.WriteLine("You've got some money.");
                    }
                    else if (money < 500)
                    {
                        Console.WriteLine("You've got a lot of money.");
                    }
                    Console.WriteLine();
                }
                //AAAAAAAAAAAAAAAAAAAAAAAAAAA DONE



                //EEEEEEEEEEEEEEEEEEEEEEEEEEE DONE
                else
                {
                    Console.WriteLine("Invalid response!");
                    Console.WriteLine();
                }
                //EEEEEEEEEEEEEEEEEEEEEEEEEEE DONE


                //RRRRRRRRRRRRRRRRRRRRRRRRRRR DONE
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
                //RRRRRRRRRRRRRRRRRRRRRRRRRRR DONE
            }
        }
        public static void Parking(int money)
        {
            int bill;
            Console.WriteLine("Welcome to Sam's Parking garage.");
            Console.WriteLine("First hour costs $4.");
            Console.WriteLine("Additional hours cost $2.");
            Console.WriteLine("Max cost is $20");
            Console.WriteLine();
            Console.Write("How many minutes were you parked for? ");
            int mins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //1
            if (mins >= 1 && mins <= 60)
            {
                Console.WriteLine($"You were parked for {mins} minutes. That means I'll charge for 1 hour.");
                Console.WriteLine("Your bill is $4");
                bill = 4;
                if (money >= bill)
                {
                    Console.WriteLine("Thank you for paying your bill.");
                }
                else if (money < bill)
                {
                    Console.WriteLine("You don't have enough to pay your bill.");
                }
            }
            //1

            //2
            else if (mins >= 61 && mins <= 120)
            {
                Console.WriteLine($"You were parked for {mins} minutes. That means I'll charge for 2 hours.");
                Console.WriteLine("Your bill is $6");
                bill = 6;
                if (money >= bill)
                {
                    Console.WriteLine("Thank you for paying your bill.");
                }
                else if (money < bill)
                {
                    Console.WriteLine("You don't have enough to pay your bill.");
                }
            }
            //2

            //3
            else if (mins >= 121 && mins <= 180)
            {
                Console.WriteLine($"You were parked for {mins} minutes. That means I'll charge for 3 hours.");
                Console.WriteLine("Your bill is $8");
                bill = 8;
                if (money >= bill)
                {
                    Console.WriteLine("Thank you for paying your bill.");
                }
                else if (money < bill)
                {
                    Console.WriteLine("You don't have enough to pay your bill.");
                }
            }
            //3

            //4
            else if (mins >= 181 && mins <= 240)
            {
                Console.WriteLine($"You were parked for {mins} minutes. That means I'll charge for 4 hours.");
                Console.WriteLine("Your bill is $10");
                bill = 10;
                if (money >= bill)
                {
                    Console.WriteLine("Thank you for paying your bill.");
                }
                else if (money < bill)
                {
                    Console.WriteLine("You don't have enough to pay your bill.");
                }
            }
            //4

            //5
            else if (mins >= 241 && mins <= 300)
            {
                Console.WriteLine($"You were parked for {mins} minutes. That means I'll charge for 5 hours.");
                Console.WriteLine("Your bill is $12");
                bill = 12;
                if (money >= bill)
                {
                    Console.WriteLine("Thank you for paying your bill.");
                }
                else if (money < bill)
                {
                    Console.WriteLine("You don't have enough to pay your bill.");
                }
            }
            //5

            //6
            else if (mins >= 301 && mins <= 360)
            {
                Console.WriteLine($"You were parked for {mins} minutes. That means I'll charge for 6 hours.");
                Console.WriteLine("Your bill is $14");
                bill = 14;
                if (money >= bill)
                {
                    Console.WriteLine("Thank you for paying your bill.");
                }
                else if (money < bill)
                {
                    Console.WriteLine("You don't have enough to pay your bill.");
                }
            }
            //6

            //7
            else if (mins >= 361 && mins <= 420)
            {
                Console.WriteLine($"You were parked for {mins} minutes. That means I'll charge for 7 hours.");
                Console.WriteLine("Your bill is $16");
                bill = 16;
                if (money >= bill)
                {
                    Console.WriteLine("Thank you for paying your bill.");
                }
                else if (money < bill)
                {
                    Console.WriteLine("You don't have enough to pay your bill.");
                }
            }
            //7

            //8
            else if (mins >= 421 && mins <= 480)
            {
                Console.WriteLine($"You were parked for {mins} minutes. That means I'll charge for 8 hours.");
                Console.WriteLine("Your bill is $18");
                bill = 18;
                if (money >= bill)
                {
                    Console.WriteLine("Thank you for paying your bill.");
                }
                else if (money < bill)
                {
                    Console.WriteLine("You don't have enough to pay your bill.");
                }
            }
            //8

            //9
            else if (mins >= 481 && mins <= 540)
            {
                Console.WriteLine($"You were parked for {mins} minutes. That means I'll charge for 9 hours.");
                Console.WriteLine("Your bill is $20");
                bill = 20;
                if (money >= bill)
                {
                    Console.WriteLine("Thank you for paying your bill.");
                }
                else if (money < bill)
                {
                    Console.WriteLine("You don't have enough to pay your bill.");
                }
            }
            //9

            //10
            else if (mins >= 541)
            {
                Console.WriteLine($"You were parked for {mins} minutes. That means I'll charge you the max amount.");
                Console.WriteLine("Your bill is $20");
                bill = 20;
                if (money >= bill)
                {
                    Console.WriteLine("Thank you for paying your bill.");
                }
                else if (money < bill)
                {
                    Console.WriteLine("You don't have enough to pay your bill.");
                }
            }
            //10

            //11
            else if (mins <= 0)
            {
                Console.WriteLine("Invalid response!");
            }
            //11

            //12
            else
            {
                Console.WriteLine("ERROR!");
            }
            //12
        }
        public static void Hurricane()
        {
            Console.WriteLine("There's a hurricane going on. What level category is it at? ");
            int level = Convert.ToInt32(Console.ReadLine());
            int input = Convert.ToInt32(Console.ReadLine());
            switch (level)
            {
                bool v = level == 1; Console.WriteLine();
                    
            bool t = level == 2; Console.WriteLine();
            
            
        }
    }
}
