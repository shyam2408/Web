using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml;

namespace SyncHotel
{
    public class Operations
    {
        public static CustomList<UserDetails> users = new();
        public static CustomList<RoomDetails> rooms = new();
        public static CustomList<RoomSelectionDetails> selections = new();
        public static CustomList<WishListDetails> wishLists = new();
        public static CustomList<BookingDetails> bookings = new();

        //Cookies or sessions
        static UserDetails currentLoggedInUser;

        public void DefaultData()
        {
            UserDetails user1 = new("Ravichandran", "995875777", "347777378383", "ravi@gmail.com", "Chennai", FoodType.Veg, GenderDetails.Male, 5000);
            UserDetails user2 = new("Baskaran", "448844848", "474777477477", "baskar@gmail.com", "Chennai", FoodType.NonVeg, GenderDetails.Male, 6000);
            users.AddRange(new CustomList<UserDetails> { user1, user2 });

            RoomDetails room1 = new(RoomType.Standard, 2, 500);
            RoomDetails room2 = new(RoomType.Standard, 4, 700);
            RoomDetails room3 = new(RoomType.Standard, 2, 500);
            RoomDetails room4 = new(RoomType.Standard, 2, 500);
            RoomDetails room5 = new(RoomType.Standard, 2, 500);
            RoomDetails room6 = new(RoomType.Delux, 2, 1000);
            RoomDetails room7 = new(RoomType.Delux, 2, 1000);
            RoomDetails room8 = new(RoomType.Delux, 4, 1400);
            RoomDetails room9 = new(RoomType.Delux, 4, 1400);
            RoomDetails room10 = new(RoomType.Suit, 2, 2000);
            RoomDetails room11 = new(RoomType.Suit, 2, 2000);
            RoomDetails room12 = new(RoomType.Suit, 2, 2000);
            RoomDetails room13 = new(RoomType.Suit, 4, 2500);
            rooms.AddRange(new CustomList<RoomDetails> { room1, room2, room3, room4, room5, room6, room7, room8, room9, room10, room11, room12, room13 });

            RoomSelectionDetails selection1 = new("WSID3001", "BID4001", "RID2001", new DateTime(2024, 11, 11, 06, 00, 00), new DateTime(2024, 11, 12, 02, 0, 0), 750, 1.5, RoomBookingStatus.Booked);
            RoomSelectionDetails selection2 = new("WSID3002", "BID4001", "RID2002", new DateTime(2024, 11, 11, 10, 00, 00), new DateTime(2024, 11, 12, 09, 0, 0), 700, 1, RoomBookingStatus.Booked);
            RoomSelectionDetails selection3 = new("WSID3003", "BID4002", "RID2003", new DateTime(2024, 11, 12, 09, 00, 00), new DateTime(2024, 11, 13, 09, 0, 0), 500, 1, RoomBookingStatus.Cancelled);
            RoomSelectionDetails selection4 = new("WSID3004", "BID4002", "RID2006", new DateTime(2024, 11, 11, 06, 00, 00), new DateTime(2024, 11, 12, 12, 30, 0), 500, 1.5, RoomBookingStatus.Cancelled);
            selections.AddRange(new CustomList<RoomSelectionDetails> { selection1, selection2, selection3, selection4 });

            WishListDetails wish1 = new("SF1001", "RID2001", 750, new DateTime(2024, 11, 12, 09, 00, 00), new DateTime(2024, 11, 13, 09, 0, 0));
            WishListDetails wish2 = new("SF1001", "RID2002", 700, new DateTime(2024, 11, 12, 06, 00, 00), new DateTime(2024, 11, 13, 12, 30, 0));
            WishListDetails wish3 = new("SF1002", "RID2001", 750, new DateTime(2025, 02, 27, 09, 00, 00), new DateTime(2025, 02, 28, 10, 0, 0));
            WishListDetails wish4 = new("SF1001", "RID2001", 750, new DateTime(2025, 03, 03, 10, 00, 00), new DateTime(2025, 03, 04, 11, 0, 0));
            wishLists.AddRange(new CustomList<WishListDetails> { wish1, wish2, wish3, wish4 });

            BookingDetails booking1 = new("SF1001", 1450, new DateTime(2024, 11, 10), BookingStatus.Booked);
            BookingDetails booking2 = new("SF1002", 2000, new DateTime(2024, 11, 10), BookingStatus.Cancelled);
            bookings.AddRange(new CustomList<BookingDetails> { booking1, booking2 });

        }

        public void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("***** Main Menu *****");
                System.Console.WriteLine("Enter Option :\n1. UserRegistraction\n2. Login\n3. Exit");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }
                    case 3:
                        {
                            flag = false;
                            System.Console.WriteLine("Exit from Main menu");
                            break;
                        }

                }

            } while (flag);
        }

        private void UserRegistration()
        {
            System.Console.WriteLine("***** User Registration *****");
            /*
                1.	User Registration:
                Need to get the details below from the user for the user registration.
                •	Username
                •	Mobile Number
                •	Aadhar Number
                •	Email
                •	Address
                •	Food type (Veg, Nonveg)
                •	Gender
                •	WalletBalance
                then, we need to display the “Registration successful” then show you UserID (auto-generated UserID).
            */

            System.Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            System.Console.Write("Enter Mobile Number : ");
            string mobileNumber = Console.ReadLine();
            System.Console.Write("Enter Aadhar Number : ");
            string aadharNumber = Console.ReadLine();
            System.Console.Write("Enter Email : ");
            string email = Console.ReadLine();
            System.Console.Write("Enter your Address : ");
            string address = Console.ReadLine();
            System.Console.Write("Enter foodType (Veg/Nonveg) : ");
            FoodType foodType = Enum.Parse<FoodType>(Console.ReadLine(), true);
            System.Console.Write("Enter your Gender : ");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            System.Console.Write("Enter your WalletBalance : ");
            double walletBalance = double.Parse(Console.ReadLine());

            UserDetails user = new(name, mobileNumber, aadharNumber, email, address, foodType, gender, walletBalance);
            users.Add(user);

            System.Console.WriteLine($"Your Registration Successfully Done. Your registred UserID is : {user.UserID}");
        }

        private void Login()
        {
            System.Console.WriteLine("***** User Login *****");

            /*
              •	Ask and get the “UserID” from the user. Check the “UserID” in the users list.
              •	If the UserID does not exist, display “Invalid UserID. Please enter a valid one.”. Then return the main menu.
              •	If a UserID exists, show the below submenu.
             1.	ViewCustomerProfile
             2.	AddToWishList
             3.	BookRoom
             4.	CancelBooking
             5.	BookingHistory
             6.	WalletRecharge
             7.	ShowWalletBalance
             8.	Exit 

            */
            System.Console.WriteLine("Enter UesrID for Login : ");
            string userID = Console.ReadLine().ToUpper();

            if (SearchUtility<UserDetails>.BinarySearch(users, userID, "UserID", out currentLoggedInUser) > -1)
            {
                System.Console.WriteLine("Login Successful.");
                SubMenu();
            }
            else
            {
                System.Console.WriteLine("Invalid UserID.");
            }
        }

        private void SubMenu()
        {

            /*
            options:
                1.	ViewCustomerProfile
                2.	AddToWishList
                3.	BookRoom
                4.	CancelBooking
                5.	BookingHistory
                6.	WalletRecharge
                7.	ShowWalletBalance
                8.	Exit 
            */
            bool flag = true;
            do
            {
                System.Console.WriteLine("***** Sub Menu *****");
                System.Console.WriteLine("Enter option : \n1. ViewCustomerProfile\n2. AddToWishList\n3. BookRoom\n4. CancelBooking\n5. BookingHistory\n6. WalletRecharge\n7. ShowWalletBalance\n8. Exit");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            ViewCustomerProfile();
                            break;
                        }
                    case 2:
                        {
                            AddToWishList();
                            break;
                        }
                    case 3:
                        {
                            BookRoom();
                            break;
                        }
                    case 4:
                        {
                            CancelBooking();
                            break;
                        }
                    case 5:
                        {
                            BookingHistory();
                            break;
                        }
                    case 6:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 7:
                        {
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            flag = false;
                            System.Console.WriteLine("Exit from Sub menu");
                            break;
                        }
                }
            } while (flag);
        }

        private void ViewCustomerProfile()
        {
            System.Console.WriteLine("***** View CustomerProfile *****");

            CustomList<UserDetails> users1 = new();

            // Show all the details of the currentLoggedInUser using users list.
            foreach (UserDetails user in users)
            {
                if (currentLoggedInUser.UserID.Equals(user.UserID))
                {
                    users1.Add(user);
                    break;
                }
            }
            GridView<UserDetails>.PrintTables(users1);
        }

        private void AddToWishList()
        {
            /*
                1.	Ask and get the FromDate and ToDate with Time from the user.
                2.	Traverse the RoomList and show available rooms by comparing RoomID with room selection list and
                    checking it is in not “Booked” state.
                3.	Ask the customer to select a room by using “RoomID”.
                4.	Validate user provided RoomID by traversing the roomDetail list. If the RoomID is not valid,
                    then show “RoomID is Invalid. Please select another RoomID”.
                5.	If RoomID is valid, then check whether the room is available or not by traversing the room selection list and 
                    checking the RoomID, and from, to dates and its status is not booked.
                6.	If RoomID is not available display “Room is already Booked”.
                7.	If valid, then create wishList object with UserID, RoomID, PriceOfRoom, FromDate, ToDate for the selected room, 
                    then add the created wishList object to the wishList then show “Booking Successfully added to WishList”.
                8.	Ask the customer if they wish to add another room to their cart. If the customer chooses “Yes”,
                    then repeat the steps from “3 to 8”.
                9.	If the customer chooses “No”, then go to the Sub Menu Options.
            */
            System.Console.WriteLine("***** AddToWishLis *****");
            //1.Ask and get the FromDate and ToDate with Time from the user.
            System.Console.WriteLine("Enter From Date {dd/mm/yyyy hh:mm:ss:(AM/PM)}");
            DateTime fromDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss:tt", null);
            System.Console.WriteLine("Enter ToDate {dd/mm/yyyy hh:mm:ss:(AM/PM)}");
            DateTime toDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss:tt", null);

            //2.show available rooms by comparing RoomID with room selection list and checking it is in not “Booked” state.
            CustomList<RoomDetails> rooms1 = new();
            foreach (RoomDetails room1 in rooms)
            {
                foreach (RoomSelectionDetails selection in selections)
                {
                    if (!selection.BookingStatus.Equals(RoomBookingStatus.Booked))
                    {
                        rooms1.Add(room1);
                        break;
                    }
                }
            }

            //user for repeat the process
            string option = "";
            do
            {
                //2.show available rooms
                if (rooms.Count > 0)
                {
                    GridView<RoomDetails>.PrintTables(rooms1);
                }
                //3.Ask the customer to select a room by using “RoomID”.
                System.Console.WriteLine("Enter a Room ID : ");
                string roomID = Console.ReadLine().ToUpper();

                //5.	If RoomID valid, then check the room is available or not by room selection list and checking the RoomID, and from, to dates and its status is not booked.
                if (SearchUtility<RoomDetails>.BinarySearch(rooms, roomID, "RoomID", out RoomDetails room) > -1)
                {
                    // then check the room is available or not by room selection list and checking the RoomID, and from, to dates and its status is not booked.
                    bool flag = true;
                    foreach (RoomSelectionDetails selection in selections)
                    {
                        if (!roomID.Equals(selection.RoomID) && !fromDate.Equals(selection.StayingDateFrom) && !toDate.Equals(selection.StayingDateTo) && !RoomBookingStatus.Booked.Equals(selection.BookingStatus))
                        {
                            flag = false;
                            //7. If valid, then create wishList object with UserID, RoomID, PriceOfRoom, FromDate, ToDate for the selected room,

                            TimeSpan date = toDate - fromDate;
                            double totalDays = Math.Round(date.TotalHours / 24, 2);
                            double priceOfRoom = room.PricePerDay * totalDays;

                            //  then add the created wishList object to the wishList then show “Booking Successfully added to WishList”.
                            WishListDetails wishList = new(currentLoggedInUser.UserID, roomID, priceOfRoom, fromDate, toDate);
                            wishLists.Add(wishList);
                            System.Console.WriteLine($"Booking Successfully added to WishList. Your wishListID is : {wishList.WishListID}");

                            //8.Ask the customer if they wish to add another room to their cart. If the customer chooses “Yes”,
                            //  then repeat the steps from “3 to 8”.
                            System.Console.WriteLine("Are you wish to add another booking to your WishList cart (yes/No): ");
                            option = Console.ReadLine().ToUpper();
                            break;
                        }

                    }
                    //6.If RoomID is not available display “Room is already Booked”.
                    System.Console.WriteLine(flag ? "Room is already Booked" : "");
                }
                else  //4.Validate If the RoomID is not valid, then show “RoomID is Invalid. Please select another RoomID”.
                {
                    option = "NO";
                    System.Console.WriteLine("RoomID is Invalid. Please select another RoomID.");
                }
            } while (option == "YES");

        }

        private void BookRoom()
        {
            System.Console.WriteLine("***** BookRoom *****");
            /*
                •	Traverse and show the wishList, and check if the room is available or 
                    not by comparing wishList RoomID with the room selectionList RoomID.
                    Compare the wishList From, To dates and selectionList From, To dates and status is not 'Booked'.  
                    If that room is available show “Available” and if not available display “Booked” in the same row.

                RoomBooking Options:
                a)	ConfirmBooking
                b)	DeleteWishList
                c)	Exit
            */

            bool flag = false;
            CustomList<WishListDetails> tempWishLists = new();
            foreach (WishListDetails wishList1 in wishLists)
            {
                if (currentLoggedInUser.UserID.Equals(wishList1.UserID))
                {
                    flag = true;
                    tempWishLists.Add(wishList1);
                }
            }

            if (flag)
            {
                ShowWishList(tempWishLists);
                //
                BookingMenu(tempWishLists);
            }
            else
            {
                System.Console.WriteLine("user doesnt have any wishlist");
            }

        }

        private void ShowWishList(CustomList<WishListDetails> list)
        {
            // check if the room is available or not by comparing wishList RoomID with the room selectionList RoomID.
            foreach (WishListDetails wishList in list)
            {
                bool flag = true;
                foreach (RoomSelectionDetails selection in selections)
                {
                    // Compare the wishList From, To dates and selectionList From, To dates and status is not 'Booked'.  
                    if (wishList.RoomID.Equals(selection.RoomID) && wishList.FromDate.Equals(selection.StayingDateFrom) && wishList.ToDate.Equals(selection.StayingDateTo) && !selection.BookingStatus.Equals(RoomBookingStatus.Booked))
                    {
                        flag = false;
                        //If that room is available show “Available” and if not available display “Booked” in the same row
                        System.Console.WriteLine($"WishListID : {wishList.WishListID,-10} | UserID : {wishList.UserID,-10} | RoomID : {wishList.RoomID,-10} | PriceOfRoom  : {wishList.PriceOfRoom,-10} | FromDate : {wishList.FromDate,-10} | ToDate : {wishList.ToDate,-10} | AvailableStatus : Already Booked.  |");
                    }
                }
                System.Console.WriteLine(flag ? $"WishListID : {wishList.WishListID,-10} | UserID : {wishList.UserID,-10} | RoomID : {wishList.RoomID,-10} | PriceOfRoom  : {wishList.PriceOfRoom,-10} | FromDate : {wishList.FromDate,-10} | ToDate : {wishList.ToDate,-10} | AvailableStatus : Available. |" : "");
            }
        }

        private void BookingMenu(CustomList<WishListDetails> tempWishLists)
        {
            /*
            RoomBooking Options:
                a)	ConfirmBooking
                b)	DeleteWishList
                c)	Exit
            */
            bool flag = true;
            do
            {
                System.Console.WriteLine("***** Booking Menu *****");
                System.Console.WriteLine("Enter Option :\n1. ConfirmBooking\n2. DeleteWishList\n3. Exit");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            ConfirmBooking(tempWishLists);
                            break;
                        }
                    case 2:
                        {
                            DeleteWishList();
                            break;
                        }
                    case 3:
                        {
                            flag = false;
                            System.Console.WriteLine("Exit from Booking Menu");
                            break;
                        }
                }

            } while (flag);

        }

        private void ConfirmBooking(CustomList<WishListDetails> tempWishLists)
        {
            /*
            1.	Create a string list to store wishListIDs and TotalAmount.
            2.	Traverse the wishList and check whether the room is available or not by using the roomSelection list check From,
                To dates and status are not booked. Find total amount for booking available rooms and 
                store the available room wishListIDs in the string list created at step 1.
            3.	Check the current customer’s wallet balance meets the TotalPrice in the wishList.
            4.	If the customer doesn’t have enough balance, then show “Insufficient balance to make your purchase.
                Needed amount to make your purchase is ______”. Then,
                a.	Ask if the customer wish to recharge their wallet, If the customer chooses “No”, then show the RoomBooking Options.
                b.	If the customer chooses “Yes”, then ask and get the recharge amount and recharge the wallet of the current customer.
                c.	Again, check if the customer’s wallet balance meets the TotalPrice.
                If the balance is insufficient repeat steps “a and b”.
            5.	If the customer has enough balance, then deduct the totalPrice from the current customer’s wallet balance.
            6.	Create a booking object with CustomerID, TotalPrice, DateOfBooking as now, BookingStatus as “Booked”.
            7.	Traverse the wishList find the room availability using selection list and
                if that room available then create a new roomSelection object and add it to the roomSelectionList.
            8.	Once all available rooms were added to selection list then remove that booked rooms from wishList by 
                using the wishListIDs created at step1.
            9.	Add the created booking object to the bookings list, then show “Booking Successful. Your BookingID is _____”.

            */

            CustomList<WishListDetails> wishLists1 = new();
            bool flag = false;
            foreach (WishListDetails wishList in wishLists)
            {
                if (currentLoggedInUser.UserID.Equals(wishList.UserID))
                {
                    flag = true;
                    wishLists1.Add(wishList);
                }
            }

            if (flag)
            {

                System.Console.WriteLine("***** Confirm Booking *****");

                //1.	
                CustomList<string> wishListIDs = new();
                //2.
                // check if the room is available or not by comparing wishList RoomID with the room selectionList RoomID.

                double totalAmount = 0;
                foreach (WishListDetails wishList in tempWishLists)
                {
                    foreach (RoomSelectionDetails selection in selections)
                    {
                        // Compare the wishList From, To dates and selectionList From, To dates and status is not 'Booked'.  
                        if (wishList.RoomID.Equals(selection.RoomID) && wishList.FromDate.Equals(selection.StayingDateFrom) && wishList.ToDate.Equals(selection.StayingDateTo) && !selection.BookingStatus.Equals(RoomBookingStatus.Booked))
                        {
                            //avlailable room's price only added to total price of cart
                            totalAmount += wishList.PriceOfRoom;
                            wishListIDs.Add(wishList.WishListID);

                        }
                    }
                }

                //3.
                string option;
                do
                {
                    if (totalAmount <= currentLoggedInUser.WalletBalance)
                    {
                        option = "NO";
                        //5.
                        currentLoggedInUser.DeductBalance(totalAmount);
                        //6.
                        BookingDetails booking = new(currentLoggedInUser.UserID, totalAmount, DateTime.Now, BookingStatus.Booked);
                        //9.
                        bookings.Add(booking);
                        System.Console.WriteLine($"Room Booking done. Booking ID is : {booking.BookingID}");

                        //7.
                        foreach (string wishlistID in wishListIDs)
                        {
                            foreach (WishListDetails wishList in tempWishLists)
                            {
                                if (wishList.WishListID.Equals(wishlistID))
                                {
                                    TimeSpan date = wishList.ToDate - wishList.FromDate;
                                    double totalDays = Math.Round(date.TotalHours / 24, 2);
                                    RoomSelectionDetails selection = new(wishlistID, booking.BookingID, wishList.RoomID, wishList.FromDate, wishList.ToDate, wishList.PriceOfRoom, totalDays, RoomBookingStatus.Booked);
                                    selections.Add(selection);
                                    tempWishLists.Remove(wishList);
                                    //System.Console.WriteLine($"Room selection done. Selecction ID is : {selection.SelectionID}");                            
                                }
                            }
                        }

                    }
                    else //4. 
                    {
                        System.Console.WriteLine($"Insufficient balance to make your purchase. Needed amount to make your purchase is : {totalAmount - currentLoggedInUser.WalletBalance}");
                        //4a.
                        System.Console.WriteLine("Are you recharge your wallet ? (yes/no) : ");
                        option = Console.ReadLine().ToUpper();
                        if (option == "YES")
                        {
                            System.Console.WriteLine("Enter amount to recharge : ");
                            double amount = double.Parse(Console.ReadLine());
                            currentLoggedInUser.WalletRecharge(amount);
                        }
                    }
                } while (option == "YES");

            }
            else
            {
                System.Console.WriteLine("User doesnt have any wishlist items.");
            }

        }

        private void DeleteWishList()
        {
            /*
                •	Show all the wishListItems of the current customer.
                •	Ask the customer to select one WishListID, the customer wants to delete.
                •	Validate if the WishListID is valid or not by traversing the wishList.
                    o	 If the WishListID is invalid, then show “Invalid WishListID” and show the BookingRoom Menu Options.
                    o	If the WishListID is valid, then remove the chosen wishList from the wishListItems list and show “Selection room is deleted from WishList successfully”.

            */

            CustomList<WishListDetails> wishLists1 = new();
            bool flag = false;
            foreach (WishListDetails wishList in wishLists)
            {
                if (currentLoggedInUser.UserID.Equals(wishList.UserID))
                {
                    flag = true;
                    wishLists1.Add(wishList);
                }
            }
            if (flag)
            {

                System.Console.WriteLine("***** Delete WishList *****");
                GridView<WishListDetails>.PrintTables(wishLists1);

                System.Console.WriteLine("enter WishListID to delete : ");
                string wishListID = Console.ReadLine().ToUpper();

                if (SearchUtility<WishListDetails>.BinarySearch(wishLists1, wishListID, "WishListID", out WishListDetails wishList) > -1)
                {
                    wishLists.Remove(wishList);
                    System.Console.WriteLine("Selection room is deleted from WishList successfully");

                }

            }
            else
            {
                System.Console.WriteLine("Invalid WishListID.");
            }



        }

        private void CancelBooking()
        {
            /*
            •	Show the current customer’s booking details by traversing the bookings list whose BookingStatus is booked.
            •	Ask the customer to choose one BookingID to cancel.
            •	Then validate the chosen BookingID is present, it belongs to that user and its status is booked by traversing the bookings list.
            •	If the BookingID is not valid, then show “Invalid BookingID” and show the Sub Menu options.
            •	If the BookingID is valid, then update the current chosen booking’s booking status as “Cancelled”.
            •	Return the TotalPrice for the booking to customer’s wallet balance.
            •	Traverse the roomSelection list and change the status of corresponding roomsSelectionList entries to “Cancelled” by checking the BookingID of selection entries. 
            •	Then, show “Booking Cancelled Successfully”.
            */

            // used for Checking current user booking are not.
            CustomList<BookingDetails> bookings1 = new();
            bool flag = false;
            foreach (BookingDetails booking in bookings)
            {
                if (currentLoggedInUser.UserID.Equals(booking.UserID))
                {
                    flag = true;
                    bookings1.Add(booking);
                }
            }
            //if current user has booking history
            if (flag)
            {
                System.Console.WriteLine("***** Cancel Booking *****");
                //Show the current customer’s booking details
                GridView<BookingDetails>.PrintTables(bookings1);


                //Ask the customer to choose one BookingID to cancel.
                System.Console.WriteLine("Enter Booking ID for Cancel booking : ");
                string bookingID = Console.ReadLine().ToUpper();

                //check BookingID is present, it belongs to that user and its status is booked by traversing the bookings list.
                bool flagBookingIDNotFound = true;
                foreach (BookingDetails booking in bookings)
                {
                    if (bookingID.Equals(booking.BookingID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                    {
                        flagBookingIDNotFound = false;
                        //then update the current chosen booking’s booking status as “Cancelled”.
                        booking.BookingStatus = BookingStatus.Cancelled;

                        //TotalPrice for the booking to customer’s wallet balance.
                        double totalAmount = 0;
                        foreach (WishListDetails wishList in wishLists)
                        {
                            foreach (RoomSelectionDetails selection in selections)
                            {
                                // Compare the wishList From, To dates and selectionList From, To dates and status is not 'Booked'.  
                                if (wishList.RoomID.Equals(selection.RoomID) && wishList.FromDate.Equals(selection.StayingDateFrom) && wishList.ToDate.Equals(selection.StayingDateTo) && !selection.BookingStatus.Equals(RoomBookingStatus.Booked))
                                {
                                    //avlailable room's price only added to total price of cart
                                    totalAmount += wishList.PriceOfRoom;
                                }
                            }
                        }
                        currentLoggedInUser.WalletRecharge(totalAmount);

                        //	Traverse the roomSelection list and change the status of corresponding roomsSelectionList entries to “Cancelled” by checking the BookingID of selection entries. 
                        //•	Then, show “Booking Cancelled Successfully”.
                        foreach(RoomSelectionDetails selection in selections)
                        {
                            if(bookingID.Equals(selection.BookingID))
                            {
                                selection.BookingStatus = RoomBookingStatus.Cancelled;
                            }
                        }
                        System.Console.WriteLine("Booking Cancelled Successfully");

                    }
                }
                //If the BookingID is not valid, then show “Invalid BookingID” and show the Sub Menu options.
                if (flagBookingIDNotFound)
                {
                    System.Console.WriteLine("Invalid BookingID");
                }
            }
            //if current user doesnt have booking history
            else
            {
                System.Console.WriteLine("No Booking history found. so please booking your details first.");
            }

        }

        private void BookingHistory()
        {

            // used for Checking current user booking are not.
            CustomList<BookingDetails> bookings1 = new();
            bool flag = false;
            foreach (BookingDetails booking in bookings)
            {
                if (currentLoggedInUser.UserID.Equals(booking.UserID))
                {
                    flag = true;
                    bookings1.Add(booking);
                }
            }
            //if current user has any booking history
            if (flag)
            {
                System.Console.WriteLine("***** Booking History *****");
                //Show the current customer’s booking details
                GridView<BookingDetails>.PrintTables(bookings1);
            }
            //if current user doesnt have booking history
            else
            {
                System.Console.WriteLine("No Booking history found. so please booking your details first.");
            }

        }

        private void WalletRecharge()
        {
            System.Console.WriteLine("***** WalletRecharge *****");
            /*
             •	Ask and get the amount from the currenLoggedInUser to recharge
             •	Recharge the wallet balance with the amount and show the current balance is ____.
            */
            System.Console.WriteLine("Enter Amount to recharge : ");
            double amount = double.Parse(Console.ReadLine());
            currentLoggedInUser.WalletRecharge(amount);
            System.Console.WriteLine(currentLoggedInUser.WalletBalance);
        }

        private void ShowWalletBalance()
        {
            System.Console.WriteLine("***** Show WalletBalance *****");

            //•	Display the currenLoggedInUser wallet balance.
            System.Console.WriteLine($"Current Balance : {currentLoggedInUser.WalletBalance}");
        }
    }
}