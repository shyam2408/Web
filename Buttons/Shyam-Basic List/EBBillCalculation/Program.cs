using System;
using System.Collections.Generic;

namespace EBBillCalculation;

class Program
{
    public static void Main(string[] args)
    {
        //CREATED LIST TO STORE EMPLOYEE DETAILS
        List<EBDetails> customerDetails = new List<EBDetails>();
        while (true)
        {
            //SHOWING MAIN MENU
            Console.WriteLine("Enter the option: 1. Registration or 2.Login 3. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        //CALLING METHOD FOR REGISDTRATION
                        Registration();
                        break;
                    }
                case 2:
                    {
                        //CALLING METHOD TO LOGIN
                        Login();
                        break;
                    }
                case 3:
                    {
                        //EXIT THE APPLICATION
                        Console.WriteLine("Exitting the application.........");
                        return;
                    }
            }
        }
        //METHOD FOR EMPLOYEE REGISTRATION
        void Registration()
        {
            //GETTING DETAILS FROM THE USER FOR REGISTRATON
            Console.WriteLine("Enter User Name :");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter your Phone number :");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your MailID :");
            string mailID = Console.ReadLine();
            Console.WriteLine("Enter number of unit used :");
            double unitsUsed = Convert.ToInt64(Console.ReadLine());
            EBDetails customer = new EBDetails(uname, phoneNumber, mailID, unitsUsed);
            //ADDING EMPLOYEE DETAILS TO THE LIST
            customerDetails.Add(customer);
            //SHOWING SUCCESSFUL MESSAGE AND EMPLOYEEID TO THE USER
            Console.WriteLine($"Regidtration Successful. You are EmployeeID is {customer.MeterID}");

        }


        void Login()
        {
            Console.WriteLine("Enter your EmployeeID :");
            //GETTING EMPLOYEEID FROM USER
            string cid = Console.ReadLine();
            foreach (EBDetails customer in customerDetails)
            {
                //CHECKING USDER ENTERED EMPLOYEEID 
                if (cid.Equals(customer.MeterID))
                {
                    Console.WriteLine($"Welcome you are {customer.MeterID}");
                    while (true)
                    {
                        //SHOWING MENU PAGE
                        Console.WriteLine("Enter your choice 1. Calculate bill  2. display details 3. exit");
                        //GETTING OPTION TO SHOW THE MENU PAGE
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                {
                                    //CALLING METHOD TO CALCULATE THE SALARY
                                    
                                    double bill=customer.CalculateBill();
                                    Console.WriteLine("your bill amount is :"+bill);
                                    break;
                                }

                            case 2:
                                {
                                    //METHOD FOR DISPLAYING THE EMPLOYEE DETAILS
                                    Console.WriteLine("Displaying the detaails.......");
                                    Console.WriteLine($"CustomerID :{customer.MeterID}\nUser Name :{customer.UserName}\nPhone Number :{customer.PhoneNumber}\nMailID :{customer.MailID}\nUnits Used :{customer.UnitsUsed}");
                                    break;
                                }
                            case 3:
                                {
                                    //EXIT THE APPLICATION
                                    Console.WriteLine("Exitting the application.........");
                                    return;
                                }
                        }
                    }
                }

                else
                {
                    //SHOWING INVALID USERID
                    Console.WriteLine("Invalid User ID");
                }
            }
        }
    }
}











