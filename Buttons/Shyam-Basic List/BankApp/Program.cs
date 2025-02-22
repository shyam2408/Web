using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace BankApp;


class Program
{
    public static void Main(string[] args)
    {
        //CREATING LIST NAMED USERS TO STORE DATA
        List<UserDetails> users = new List<UserDetails>();
        while (true)
        {
            Console.WriteLine("Enter your choice:1. Registration or 2. Login 3. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            //SHOWING SUBMENU PAGE TO THE USER
            switch (option)
            {
                case 1:
                    {
                        Register();
                        break;
                    }
                case 2:
                    {
                        Login();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Exiting the application......");
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Choice.Please try again.");
                        break;
                    }
            }
        }


        //METHOD FOR ADDING USER
        void Register()
        {
            //METHOD FOR USER REGISTRATION
            Console.WriteLine("Enter your name: ");
            String customerName = Console.ReadLine();
            Console.WriteLine("Enter balance: ");
            double balance = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter gender: ");
            ///enums
            /// enum with 
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            Console.WriteLine("Enter your phone number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your MailID");
            string mailID = Console.ReadLine();
            Console.WriteLine("Enter you Date of birth:");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            UserDetails user1 = new UserDetails(customerName, balance, gender, phoneNumber, mailID, dob);
            //ADDING USER TO THE LIST
            users.Add(user1);
            //SHOWING SUCCESSFUL MESSAGE AND CUSTOMERid TO THE USER
            Console.WriteLine($"Registration successful and your customerID is {user1.CustomerID}");
        }
        void Login()
        {
            Console.WriteLine("Enter your CustomeID:");
            string customerID = Console.ReadLine().ToLower();
            foreach (UserDetails user in users)
            {
                //CHECKING CUSTOMER ID WITH USER ENTERED INPUT
                if (customerID.Equals(user.CustomerID.ToLower()))
                {
                    Console.WriteLine($"Welcome {user.CustomerName}");
                    while (true)
                    {
                        //SHOWING MAIN MENU
                        Console.WriteLine("Enter your choice:1. Deposit, 2. withdraw, 3.balance check 4. exit");
                        int option = Convert.ToInt32(Console.ReadLine());
                        ///showing submenu page to the user
                        switch (option)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Enter deposit amount:");
                                    double deposit = Convert.ToInt64(Console.ReadLine());
                                    //CALLING CLASS METHODS WITH THE HELP OF OBJECT
                                    user.Deposit(deposit);
                                    break;
                                }
                            case 2:
                                {
                                    //CHECKING AMOUNT TO WITHDRAW
                                    Console.WriteLine("Enter amount to Withdraw:");
                                    double withdraw = Convert.ToInt64(Console.ReadLine());
                                    user.WithDraw(withdraw);
                                    break;
                                }
                            case 3:
                                {
                                    //CHECKING BALANCE AMOUNT
                                    Console.WriteLine("Balance amount:" + user.Balance);
                                    break;
                                }
                            case 4:
                                {
                                    //showing main menu 
                                    Console.WriteLine("Exiting the application");
                                    return;
                                }
                        }
                    }
                }
                else
                {
                    //SHOWING INVALID USER
                    Console.WriteLine("Invalid User ID");
                }
            }
        }
    }
}



