using System;
using System.Dynamic;

namespace ATMLab
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();

            while (true)
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");

                string userResponse = Console.ReadLine();

                if (userResponse == "1")
                {
                    Console.WriteLine("Hello, new user");
                    Console.WriteLine("What is your username?");
                    string username = Console.ReadLine();

                    Console.WriteLine("What is your password?");
                    string password = Console.ReadLine();

                    atm.Register(username, password);
                }

                if (userResponse == "2")
                {
                    Console.Write("What is your username? ");
                    string username = Console.ReadLine();

                    Console.Write("What is your password? ");
                    string password = Console.ReadLine();

                    atm.Login(username, password);
                } 

                if(atm.CurrentAccount != null)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Check Balance");
                        Console.WriteLine("2. Deposit");
                        Console.WriteLine("3. Withdraw");
                        Console.WriteLine("4. Logout");

                        userResponse = Console.ReadLine();

                        if (userResponse == "1")
                        {
                            atm.CheckBalance();
                        }
                        else if (userResponse == "2")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            int amount = int.Parse(Console.ReadLine());

                            atm.Deposit(amount);
                        }
                        else if (userResponse == "3")
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            int amount = int.Parse(Console.ReadLine());

                            atm.Withdraw(amount);
                        }
                        else if (userResponse == "4")
                        {
                            atm.Logout();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, I didn't understand that.");
                        } 
                    }
                }
            }
        }
    }
}
