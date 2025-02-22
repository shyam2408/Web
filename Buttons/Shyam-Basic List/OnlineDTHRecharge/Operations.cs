using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace OnlineDTHRecharge
{
    public class Operations
    {
        List<UserRegistrationDetails> users = new List<UserRegistrationDetails>();
        List<PackDetails> packs = new List<PackDetails>();
        List<RechargeHistoryDetails> recharges = new List<RechargeHistoryDetails>();
        //creting cookie for the easy access
        UserRegistrationDetails currentUser;
        //creating cookie to find current pack
        PackDetails currentPack;

        //adding Default values for list users 
        public void DefaultValue()
        {
            //adding default value  for users
            UserRegistrationDetails user1 = new("John", "9746646466", GenderDetails.Male, "john@gmail.com ", 500);
            UserRegistrationDetails user2 = new("Merlin", "9782136543", GenderDetails.Female, "merlin@gmail.com", 150);
            //addding users to the list
            users.AddRange(new List<UserRegistrationDetails>() { user1, user2 });
            //adding default value  for packs
            PackDetails pack1 = new("RC150", "Pack1", 150, 28, 50);
            PackDetails pack2 = new("RC300", "Pack2", 300, 56, 75);
            PackDetails pack3 = new("RC500", "Pack3", 500, 28, 200);
            PackDetails pack4 = new("RC1500", "Pack4", 1500, 365, 200);
            //addding packs to the list
            packs.AddRange(new List<PackDetails>() { pack1, pack2, pack3, pack4 });
            //adding default value  for HistoryDetails
            RechargeHistoryDetails recharge1 = new("UID1001", "RC150", new DateTime(2021, 11, 30), new DateTime(2021, 11, 30), new DateTime(2021, 12, 27), 150, 50);
            RechargeHistoryDetails recharge2 = new("UID1001", "RC300", new DateTime(2021, 11, 30), new DateTime(2021, 12, 28), new DateTime(2022, 02, 22), 300, 75);
            RechargeHistoryDetails recharge3 = new("UID1002", "RC150", new DateTime(2025, 01, 01), new DateTime(2025, 01, 01), new DateTime(2025, 02, 28), 150, 50);
            recharges.AddRange(new List<RechargeHistoryDetails>() { recharge1, recharge2, recharge3 });
        }


        public void MainMenu()
        {
            //initializes try block to avoid exception
            try
            {
                //initializes flag to exit form while loop
                bool flag = true;
                do
                {
                    Console.WriteLine("Enter the option you want\n1.	User Registration\n2.	User Login\n3.	Exit");
                    //getting option from the user
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                Registration();
                                break;
                            }
                        case 2:
                            {
                                Login();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Exit the application..");
                                //indicate flag to exit form the while loop
                                flag = false;
                                break;
                            }
                    }
                } while (flag);
            }
            //cathching Exception and showing messages to the user
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }

        public void Registration()
        {
            //initializes flag to exit form while loop
            try
            {
                //getting inputs
                Console.WriteLine("Registration Process.......");
                Console.WriteLine("Enter your UserName:");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter your MobileNumber:");
                string mobileNumber = Console.ReadLine();
                Console.WriteLine("Enter Gender:");
                GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
                Console.WriteLine("Enter your EmailID:");
                string emailID = Console.ReadLine();
                Console.WriteLine("Enter your WalletBalance:");
                double walletBalance = Convert.ToInt64(Console.ReadLine());
                //creating object
                UserRegistrationDetails user = new(userName, mobileNumber, gender, emailID, walletBalance);
                users.Add(user);
                Console.WriteLine($"registration Successful your ID is {user.UserID}");

            }
            //cathching Exception and showing messages to the user
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }

        public void Login()
        {
            Console.WriteLine("Enter your Id :");
            string userEnteredID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserRegistrationDetails user in users)
            {
                //checking user entered datails with userid
                if (userEnteredID.Equals(user.UserID))
                {
                    flag = false;
                    currentUser = user;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid User......");
            }
        }
        public void SubMenu()
        {   //initializes flag to exit form while loop
            try
            {
                Console.WriteLine("Login Process.......");
                bool flag = true;
                do
                {
                    Console.WriteLine("Enter the option you want :");
                    Console.WriteLine("1.	Current Pack \n2.	Pack Recharge \n3.	Wallet Recharge \n4.	View Pack Recharge History \n5.	Show Wallet balance \n6.	Exit ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                CurrentPack();
                                break;
                            }
                        case 2:
                            {
                                PackRecharge();
                                break;
                            }
                        case 3:
                            {
                                Recharge();
                                break;
                            }
                        case 4:
                            {
                                ViewPackRechargeHistory();
                                break;
                            }
                        case 5:
                            {
                                ShowWalletBalance();
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Exiting the application ");
                                flag = false;
                                break;
                            }
                    }
                } while (flag);


            }
            //cathching Exception and showing messages to the user
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void CurrentPack()
        {
            try
            {

                //Display the details of the user's current pack from the PackRecharges list,
                //including ensure this pack they are currently using. Display the below details,
                bool flag = true;
                foreach (RechargeHistoryDetails recharge in recharges)
                {
                    if (currentUser.UserID.Equals(recharge.UserID))
                    {
                        //changing flag to indicate not found
                        flag = false;
                        Console.WriteLine($"|{recharge.UserID,-15} |{recharge.PackID,-15} |{recharge.RechargeDate,-15} | {recharge.StartDate,-15} | {recharge.ValidTill,-15}| {recharge.RechargeAmount,-15} | {recharge.NumberOfChannels}");
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Recharge Expired or no recharge history found");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void PackRecharge()
        {
            try
            {
                //Show the available pack details from the packsList.
                foreach (PackDetails pack in packs)
                {
                    Console.WriteLine($"{pack.PackID,-15} | {pack.PackName,-15} | {pack.Price,-15} |  {pack.Validity} | {pack.NunmberOfChannels}");
                }
                //Ask and get the Pack ID from the available packs.
                Console.WriteLine("Enter the PackID :");
                string userEnteredPackID = Console.ReadLine();
                bool flag = true;
                //Check if the selected Pack ID is available in the packs list:
                foreach (PackDetails pack in packs)
                {
                    if (userEnteredPackID.Equals(pack.PackID))
                    {
                        //Check use has enough balance to recharge to this pack. 
                        flag = false;
                        currentPack = pack;
                        if (currentUser.WalletBalance > pack.Price)
                        {
                            //If the user has already recharged, check the expiry date (Valid till) of the previous recharge
                            foreach (RechargeHistoryDetails recharge in recharges)
                            {
                                if (currentUser.UserID.Equals(recharge.UserID) && DateTime.Now > recharge.ValidTill)
                                {
                                    Console.WriteLine("Previous recharge Expired");
                                    //o	If the previous pack expired, the new pack would start from today. The recharge date is today,
                                    // valid till is from today to pack duration. 
                                    recharge.StartDate = DateTime.Now;
                                    recharge.ValidTill.AddDays(pack.Validity);
                                    //Using “DeductBalance” method then deduct the recharge amount from the currentUser wallet balance.
                                    currentUser.DeductBalance(pack.Price);
                                    //Create recharge entry and add it to the recharge history list
                                    RechargeHistoryDetails newReacharge = new(currentUser.UserID, pack.PackID, recharge.RechargeDate, recharge.StartDate, recharge.ValidTill, recharge.RechargeAmount, recharge.NumberOfChannels);
                                    recharges.Add(newReacharge);
                                    Console.WriteLine("REcharge Successful " + newReacharge.RechargeID);
                                    System.Console.WriteLine("your new validity Date :"+newReacharge.ValidTill);
                                    break;
                                }
                                else if (currentUser.UserID.Equals(recharge.UserID) && DateTime.Now < recharge.ValidTill)
                                {
                                    Console.WriteLine("pack not expired");
                                    //If the pack is not expired, then the recharge date is today, 
                                    //start date is the next date of current running pack. 
                                    //Valid till date is the date from start date to the mentioned packs duration. 
                                    recharge.RechargeDate = DateTime.Now;
                                    recharge.StartDate = DateTime.Now.AddDays(1);
                                    recharge.ValidTill.AddDays(pack.Validity);
                                    //Using “DeductBalance” method then deduct the recharge amount from the currentUser wallet balance.
                                    currentUser.DeductBalance(pack.Price);
                                    //Create recharge entry and add it to the recharge history list
                                    RechargeHistoryDetails newReacharge = new(currentUser.UserID, pack.PackID, recharge.RechargeDate, recharge.StartDate, recharge.ValidTill, recharge.RechargeAmount, recharge.NumberOfChannels);
                                    recharges.Add(newReacharge);
                                    Console.WriteLine("REcharge Successful " + newReacharge.RechargeID);
                                    System.Console.WriteLine("your new validity Date :"+newReacharge.ValidTill);
                                    break;
                                }
                                else
                                {
                                    recharge.RechargeDate = DateTime.Now;
                                    recharge.StartDate = DateTime.Now.AddDays(1);
                                    recharge.ValidTill.AddDays(pack.Validity);
                                    //Using “DeductBalance” method then deduct the recharge amount from the currentUser wallet balance.
                                    currentUser.DeductBalance(pack.Price);
                                    //Create recharge entry and add it to the recharge history list
                                    RechargeHistoryDetails newReacharge = new(currentUser.UserID, pack.PackID, recharge.RechargeDate, recharge.StartDate, recharge.ValidTill, recharge.RechargeAmount, recharge.NumberOfChannels);
                                    recharges.Add(newReacharge);
                                    Console.WriteLine("REcharge Successful " + newReacharge.RechargeID);
                                    System.Console.WriteLine("your new validity Date :"+newReacharge.ValidTill);
                                    break;
                                }
                    
                            }

                        }
                        //then reeturn to the submenu
                        else
                        {
                            Console.WriteLine("you have insufficient balance");
                        }
                    }
                }
                //If the Pack ID is not available, show the message: "This Pack ID is not available."
                if (flag)
                {
                    Console.WriteLine("This Pack ID is not available.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void Recharge()
        {
            try
            {
                //Ask and get the amount from user to WalletRecharge.
                //Use the WalletRecharge Method and Update the WalletBalance to the current user.
                Console.WriteLine("Enter the amount to Recharge in Wallet:");
                double amount = Convert.ToInt64(Console.ReadLine());
                currentUser.WalletRecharge(amount);
                Console.WriteLine($"Recharge successful..your balance is  {currentUser.WalletBalance}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void ViewPackRechargeHistory()
        {
            try
            {
                bool flag = true;
                //Display the recharge details in the recharges list for the current user.
                foreach (RechargeHistoryDetails recharge in recharges)
                {
                    if (currentUser.UserID.Equals(recharge.UserID))
                    {
                        Console.WriteLine($"{recharge.RechargeID,-15}| {recharge.UserID,-15} |{recharge.PackID,-15} |{recharge.RechargeDate,-15} | {recharge.StartDate,-15} | {recharge.ValidTill,-15}| {recharge.RechargeAmount,-15} | {recharge.NumberOfChannels}");


                    }
                }
                //If there is no history, then show “History is not found”.
                if (flag)
                {
                    Console.WriteLine("no recharge histories found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void ShowWalletBalance()
        {
            try
            {
                //Display the Current user WalletBalance
                Console.WriteLine($"your balance is {currentUser.WalletBalance}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
    }
}