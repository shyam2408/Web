using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;

namespace EmployeeManagement;

class Program
{
    public static void Main(string[] args)
    {
        //CREATED LIST TO STORE EMPLOYEE DETAILS
        List<EmployeeDetails> EDetails = new List<EmployeeDetails>();
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
            Console.WriteLine("Enter Employee Name :");
            string ename = Console.ReadLine();
            Console.WriteLine("Enter your role :");
            string role = Console.ReadLine();
            Console.WriteLine("Enter your Work Location :");
            WorkLocation location = Enum.Parse<WorkLocation>(Console.ReadLine(), true);
            Console.WriteLine("Enter your Team name :");
            string Tname = Console.ReadLine();
            Console.WriteLine("Enter your Date of joining :");
            DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("Enter your gender :");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            EmployeeDetails employee = new EmployeeDetails(ename, role, location, Tname, doj, gender);
            //ADDING EMPLOYEE DETAILS TO THE LIST
            EDetails.Add(employee);
            //SHOWING SUCCESSFUL MESSAGE AND EMPLOYEEID TO THE USER
            Console.WriteLine($"Regidtration Successful. You are EmployeeID is {employee.EID}");

        }


        void Login()
        {
            Console.WriteLine("Enter your EmployeeID :");
            //GETTING EMPLOYEEID FROM USER
            string eid = Console.ReadLine();
            foreach (EmployeeDetails employee in EDetails)
            {
                //CHECKING USDER ENTERED EMPLOYEEID 
                if (eid.Equals(employee.EID))
                {
                    Console.WriteLine($"Welcome you are {employee.EName}");
                    while (true)
                    {
                        //SHOWING MENU PAGE
                        Console.WriteLine("Enter your choice 1. Calculate salary 2. display details 3. exit");
                        //GETTING OPTION TO SHOW THE MENU PAGE
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                {
                                    //CALLING METHOD TO CALCULATE THE SALARY
                                    Console.WriteLine("Enter Current month:");
                                    int month=Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter current year:");
                                    int year=Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter a number of leaves Taken :");
                                    int leavesTaken=Convert.ToInt32(Console.ReadLine());
                                    employee.CalculateSal(leavesTaken,month,year);
                                    break;
                                }

                            case 2:
                                {
                                    //METHOD FOR DISPLAYING THE EMPLOYEE DETAILS
                                    Display(eid);
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

        void Display(string eid)
        {
            foreach(EmployeeDetails employee in EDetails)
            {
                if(eid.Equals(employee.EID))
                {
                    Console.WriteLine("Displaying the detaails.......");
                    Console.WriteLine($"CustomerID :{employee.EID}\nSEmployee Name :{employee.EName}\nRole :{employee.Role}\nWorkLocation :{employee.Location}\nTeam Name :{employee.TName}\nDate Of Joining :{employee.DOJ}\nGender :{employee.Gender}");
                }
            }
        }
    }
}











