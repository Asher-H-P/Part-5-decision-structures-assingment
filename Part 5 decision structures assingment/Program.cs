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
            Bank();
        }
        public static void Bank()
        {
            Random generator = new Random();
            bool done = false;
            double money = 150.75;
            double rent = generator.Next(100, 400);
            while (!done)
            {
                Console.WriteLine("Thank you for using a BoB ATM. How may I help you?");
                Console.WriteLine("Each use costs ¢75.");
                Console.WriteLine("Deposit (D)");
                Console.WriteLine("Withdraw (W)");
                Console.WriteLine("Bill Payment (BP)");
                Console.WriteLine("Account Balance (AB)");
                Console.WriteLine("Quit (Q)");
                string choice = Console.ReadLine().ToUpper();
                Console.WriteLine();


                //QQQQQQQQQQQQQQQQQQQQQQQQQQQ DONE
                if (choice == "QUIT" || choice == "Q")
                {
                    Console.WriteLine("Goodbye!");
                    done = true;
                }
                //QQQQQQQQQQQQQQQQQQQQQQQQQQQ DONE


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
                    else
                    {
                        Console.WriteLine("ERROR!");
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
    }
}
