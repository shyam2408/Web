using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class Operations
    {
        List<CustomerDetails> customers = new List<CustomerDetails>();
        List<FoodDetails> foods = new List<FoodDetails>();
        List<BookingDetails> bookings = new List<BookingDetails>();
        List<CartDetails> carts = new List<CartDetails>();
        List<PurchasedItem> purchaseds = new List<PurchasedItem>();
        double currentTotalPrice = 0;
        PurchasedItem purchased1;
        CustomerDetails currentLoginedCustomer;
        public void DefaultData()
        {
            //adding default value
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Ettapparajan", "974774646", "ravi@gmail.com", new DateTime(1999, 11, 11), GenderDetails.Male, 10000);
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Sethurajan", "847575775", "baskaran@gmail.com", new DateTime(1999, 11, 11), GenderDetails.Male, 15000);
            customers.AddRange(new List<CustomerDetails>() { customer1, customer2 });
            FoodDetails food1 = new FoodDetails("Coffee", 20, 40);
            FoodDetails food2 = new FoodDetails("Tea", 100, 50);
            FoodDetails food3 = new FoodDetails("Milk", 10, 40);
            FoodDetails food4 = new FoodDetails("Juice", 10, 10);
            FoodDetails food5 = new FoodDetails("Puff", 10, 10);
            FoodDetails food6 = new FoodDetails("Popcorn", 10, 20);
            FoodDetails food7 = new FoodDetails("Samosa", 10, 10);
            FoodDetails food8 = new FoodDetails("Sandwich", 10, 25);
            FoodDetails food9 = new FoodDetails("Pizza", 10, 20);
            FoodDetails food10 = new FoodDetails("Burger", 10, 140);
            foods.AddRange(new List<FoodDetails>() { food1, food2, food3, food4, food5, food6, food7, food8, food9, food10 });
            BookingDetails booking1 = new BookingDetails("CID1001", 220, new DateTime(2024, 09, 26), BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails("CID1002", 400, new DateTime(2024, 09, 24), BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails("CID1001", 280, new DateTime(2024, 09, 20), BookingStatus.Cancelled);
            bookings.AddRange(new List<BookingDetails>() { booking1, booking2, booking3 });
            CartDetails cart1 = new CartDetails("CID1002", "FID2002", 4, 200);
            CartDetails cart2 = new CartDetails("CID1001", "FID2001", 2, 80);
            CartDetails cart3 = new CartDetails("CID1002", "FID2003", 1, 40);
            carts.AddRange(new List<CartDetails>() { cart1, cart2, cart3 });
            PurchasedItem purchased1 = new PurchasedItem("CRID4001", "BID3001", "FID2001", 2, 80);
            PurchasedItem purchased2 = new PurchasedItem("CRID4002", "BID3001", "FID2002", 2, 100);
            PurchasedItem purchased3 = new PurchasedItem("CRID4003", "BID3001", "FID2003", 1, 40);
            PurchasedItem purchased4 = new PurchasedItem("CRID4004", "BID3002", "FID2001", 1, 40);
            PurchasedItem purchased5 = new PurchasedItem("CRID4005", "BID3002", "FID2002", 4, 200);
            PurchasedItem purchased6 = new PurchasedItem("CRID4006", "BID3002", "FID2010", 1, 140);
            PurchasedItem purchased7 = new PurchasedItem("CRID4007", "BID3002", "FID2009", 1, 20);
            PurchasedItem purchased8 = new PurchasedItem("CRID4008", "BID3003", "FID2002", 2, 100);
            PurchasedItem purchased9 = new PurchasedItem("CRID4009", "BID3003", "FID2008", 4, 100);
            PurchasedItem purchased10 = new PurchasedItem("CRID4010", "BID3003", "FID2001", 2, 80);
            purchaseds.AddRange(new List<PurchasedItem>() { purchased1, purchased2, purchased3, purchased4, purchased5, purchased6, purchased7, purchased8, purchased9, purchased10 });
        }
        public void MainMenu()
        {
            try
            {
                bool flag = true;
                do
                {
                    //getting inputs from the user
                    System.Console.WriteLine("Enter the option you want \n1. CustomerRegistration\n2. CustomerLogin\n3. Exit");
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
                                flag = false;
                                break;
                            }
                    }

                } while (flag);
            }

            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void Registration()
        {
            try
            {
                //method for registration
                Console.WriteLine("Enter Your Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Your FatherName:");
                string fatherName = Console.ReadLine();
                Console.WriteLine("Enter Your DATE OF BIRTH:");
                DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.WriteLine("Enter Gender :");
                GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
                Console.WriteLine("enter your phone number :");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine("enter your EmailId:");
                string eMailID = Console.ReadLine();
                System.Console.WriteLine("Enter your wallet Balance :");
                double balance = Convert.ToInt64(Console.ReadLine());
                CustomerDetails customer = new CustomerDetails(name, fatherName, phoneNumber, eMailID, dob, gender, balance);
                customers.Add(customer);
                System.Console.WriteLine("Registration Successful your CustomerID is " + customer.CustomerID);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void Login()
        {
            try
            {
                System.Console.WriteLine("Enter your Customer ID:");
                //getting customer ID from the user
                string customerID = Console.ReadLine().ToUpper();
                bool flag = true;
                foreach (CustomerDetails customer in customers)
                {
                    if (customerID.Equals(customer.CustomerID))
                    {
                        flag = false;
                        currentLoginedCustomer = customer;
                        SubMenu();
                        break;
                    }
                }
                if (flag)
                {
                    System.Console.WriteLine("Invalid User..........");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }

        }
        public void SubMenu()
        {
            try
            {
                bool flag = true;
                do
                {
                    //If there is no appointment history is present for the user means then show “No appointment history found”.
                    System.Console.WriteLine("Enter the option \n1. ShowCustomerDetails\n2. ShowFoodDetails\n3. WalletRecharge\n4. AddToCart\n5. Purchase\n6. CancelBooking\n7. BookingHistory\n8. ShowBalance\n9. Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                ShowCustomerDetails();
                                break;
                            }
                        case 2:
                            {
                                ShowFoodDetails();
                                break;
                            }
                        case 3:
                            {
                                WalletRecharge();
                                break;
                            }
                        case 4:
                            {
                                AddToCart();
                                break;
                            }
                        case 5:
                            {
                                Purchase();
                                break;
                            }
                        case 6:
                            {
                                CancelBooking();
                                break;
                            }
                        case 7:
                            {
                                BookingHistory();
                                break;
                            }
                        case 8:
                            {
                                ShowBalance();
                                break;
                            }
                        case 9:
                            {
                                flag = false;
                                break;
                            }
                    }
                } while (flag);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void ShowCustomerDetails()
        {
            try
            {
                //1. Show the details of current logged in customer using ShowCustomerDetails method.
                foreach (CustomerDetails customer in customers)
                {
                    if (currentLoginedCustomer.CustomerID.Equals(customer.CustomerID))
                    {
                        System.Console.WriteLine($"CustomerID :{customer.CustomerID,-15} | CustomerName :{customer.CustomerName,-15} | FatherName :{customer.FatherName,-15} | Phone:{customer.Phone,-15} | MailID :{customer.Mail,-15} | Gender :{customer.Gender,-15} | Date of Birth :{customer.DOB,-15:dd/MM/yyyy} |Wallet Balance :{customer.WalletBalance,-15}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }

        }
        public void ShowFoodDetails()
        {
            try
            {
                System.Console.WriteLine("\n*****Food details*****");
                System.Console.WriteLine($"| {"FoodID",-15} | {"Food Name",-15} | {"Quantity Available",-15} | {"Price Per Quantity",-15}");
                foreach (FoodDetails food in foods)
                {
                    System.Console.WriteLine($"FoodID :{food.FoodID,-15} | Food Name :{food.FoodName,-15} | Quantity Available :{food.QuantityAvailable,-15} | Price Per Quantity :{food.PricePerQuantity,-15}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }

        }
        public void WalletRecharge()
        {
            try
            {
                //Ask and get the amount from user to WalletRecharge.
                //Use the WalletRecharge Method and Update the WalletBalance to the current user.
                Console.WriteLine("Enter the amount to Recharge in Wallet:");
                double amount = Convert.ToInt64(Console.ReadLine());
                currentLoginedCustomer.WalletRecharge(amount);
                Console.WriteLine($"Recharge successful..your balance is  {currentLoginedCustomer.WalletBalance}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void AddToCart()
        {
            try
            {
                string option;
                do
                {
                    //1. Show the foods of “available stock” by traversing the foods list.
                    foreach (FoodDetails food in foods)
                    {
                        System.Console.WriteLine($"FoodID :{food.FoodID,-15} | FoodName :{food.FoodName,-15} | QuantityAvailabe :{food.QuantityAvailable,-15} | PricePerQuantity :{food.PricePerQuantity,-15}");
                    }
                    //1. Show the foods of “available stock” by traversing the foods list.
                    System.Console.WriteLine("Enter the food ID you want to purcahse :");
                    string currentFoodID = Console.ReadLine().ToUpper();
                    //3. Validate if the entered “FoodID is valid” by traversing the food’s list. 
                    bool flag = true;
                    foreach (FoodDetails food1 in foods)
                    {
                        if (currentFoodID.Equals(food1.FoodID))
                        {
                            flag = false;
                            //4. If the FoodID is valid, ask the customer to enter the quantity of the food the customer wants to purchase.
                            System.Console.WriteLine($"Enter the quantity number of {food1.FoodName} you want :");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            double price = quantity * food1.PricePerQuantity;
                            //5. Then create cart object (CartID should auto incremented) with UserID, FoodID, PurchaseCount entered by the customer, PriceOfCart for the selected quantity,
                            CartDetails cart = new CartDetails(currentLoginedCustomer.CustomerID, food1.FoodID, quantity, price);
                            // then add the created cart object to the cartItemsList then show “Food Successfully added to Cart”.
                            carts.Add(cart);
                            System.Console.WriteLine("Food Successfully added to the Cart your id is " + cart.CartID);
                        }
                    }
                    if (flag)
                    {
                        //If the FoodID is not valid, then show .
                        System.Console.WriteLine("FoodID is Invalid. Please enter the FoodID again");
                    }
                    //6. Ask the customer if they wish to add another Food to their cart. If the customer chooses “Yes”,
                    //  then repeat the steps from “1 to 5”.
                    System.Console.WriteLine("Do you want to add another food to your cart ?");
                    option = Console.ReadLine().ToLower();
                } while (option == "yes");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void Purchase()
        {
            try
            {
                bool flaged = true;
                foreach (CartDetails cart in carts)
                {
                    foreach (FoodDetails food in foods)
                    {
                        //1. Traverse and show the cartItems List and check the PurchaseCount of each cartItem. 
                        if (currentLoginedCustomer.CustomerID.Equals(cart.CustomerID) && cart.FoodID.Equals(food.FoodID))
                        {
                            //If it is available in foodsList stock, then show as “In stock” else “out of stock” in same row. //If it is available in foodsList stock, then show as “In stock” else “out of stock” in same row. 
                            if (cart.PurchaseCount < food.QuantityAvailable)
                            {
                                flaged = false;
                                System.Console.WriteLine($"FoodID:{food.FoodID,-15} | FoodName :{food.FoodName,-15} QuantityAvailable{food.QuantityAvailable,-15}| PriceperQuantity :{food.PricePerQuantity,-15} |In-Stock");
                                //Calculate TotalPrice of available stock items.*/
                                currentTotalPrice += cart.PriceOfCart;
                            }
                            else if (cart.PurchaseCount > food.QuantityAvailable)
                            {
                                System.Console.WriteLine($"FoodID:{food.FoodID,-15} | FoodName :{food.FoodName,-15} QuantityAvailable{food.QuantityAvailable,-15}| PriceperQuantity :{food.PricePerQuantity,-15} |Out-Of-Stock"); ;
                            }
                        }
                    }
                }
                if (flaged)
                {
                    System.Console.WriteLine("you have added No Items in the cart");
                }
                while (!flaged)
                {
                    System.Console.WriteLine("Enter the option you want :\n1. ConfirmPurchase\n2. ModifyCart\n3. DeleteCart\n4. Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                ConfirmPurchase();
                                break;
                            }
                        case 2:
                            {
                                ModifyCart();
                                break;
                            }
                        case 3:
                            {
                                DeleteCart();
                                break;
                            }
                        case 4:
                            {
                                flaged = true;
                                break;
                            }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void CancelBooking()
        {
            try
            {
                //1. Show the current customer’s booking details by traversing the bookings list whose BookingStatus is booked.
                bool flaged = true;
                foreach (BookingDetails booking in bookings)
                {
                    if (currentLoginedCustomer.CustomerID.Equals(booking.CustomerID) && booking.Booking.Equals(BookingStatus.Booked))
                    {
                        flaged = false;
                        System.Console.WriteLine($"Booking ID :{booking.BookingID,-15} | Customer ID :{booking.CustomerID,-15} | TotalPrice :{booking.TotalPrice,-15} | Date of booking :{booking.DateOfBooking.ToString("dd/MM/yyyy"),-15} | Booking Status :{booking.Booking}");
                    }
                }
                if (flaged)
                {
                    System.Console.WriteLine("No booking found");
                }
                else
                {
                    //Ask the customer to choose one BookingID to cancel, then validate if the chosen BookingID is present and its status is booked.
                    System.Console.WriteLine("Enter the bookingID you want to cancel ");
                    string currentBookingID = Console.ReadLine().ToUpper();
                    bool flag = true;
                    foreach (BookingDetails booking1 in bookings)
                    {
                        if (currentBookingID.Equals(booking1.BookingID) && booking1.Booking.Equals(BookingStatus.Booked))
                        {
                            flag = false;
                            //If the BookingID is valid, then update the current chosen booking’s booking status as cancelled
                            booking1.Booking = BookingStatus.Cancelled;
                            // and return the TotalPrice for the booking to customer’s wallet balance.
                            currentLoginedCustomer.WalletRecharge(booking1.TotalPrice);
                            //show “Booking Cancelled Successfully”.*/
                            System.Console.WriteLine("Booking Cancelled Successfully ");
                            //return the purchased item’s PurchaseCount to food details quantity.
                            foreach (PurchasedItem purchased in purchaseds)
                            {
                                if (booking1.BookingID.Equals(purchased.BookingID))
                                {
                                    foreach (FoodDetails food in foods)
                                    {
                                        if (purchased.FoodID.Equals(food.FoodID))
                                        {
                                            food.QuantityAvailable += purchased.PurchaseCount;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (flag)
                    {
                        //If the BookingID is not valid, then show “Invalid BookingID” and show the Sub Menu options.
                        System.Console.WriteLine("Invalid BookinID..plz enter the valid one..");
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void BookingHistory()
        {
            try
            {
                bool flag = true;
                foreach (BookingDetails booking in bookings)
                {
                    if (currentLoginedCustomer.CustomerID.Equals(booking.CustomerID))
                    {
                        flag = false;
                        System.Console.WriteLine($"Booking ID :{booking.BookingID,-15} | Customer ID :{booking.CustomerID,-15} | TotalPrice :{booking.TotalPrice,-15} | Date of booking :{booking.DateOfBooking.ToString("dd/MM/yyy"),-15} | Booking Status :{booking.Booking}");
                    }
                }
                if (flag)
                {
                    System.Console.WriteLine("no history found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
        public void ShowBalance()
        {
            System.Console.WriteLine("your balance is " + currentLoginedCustomer.WalletBalance);
        }
        public void ConfirmPurchase()
        {
            try
            {
                double totalPrice = 0;
                bool flaged = true;
                foreach (CartDetails cart in carts)
                {
                    foreach (FoodDetails food in foods)
                    {
                        //1. Traverse and show the cartItems List and check the PurchaseCount of each cartItem. 
                        if (currentLoginedCustomer.CustomerID.Equals(cart.CustomerID) && cart.FoodID.Equals(food.FoodID))
                        {
                            //If it is available in foodsList stock, then show as “In stock” else “out of stock” in same row. //If it is available in foodsList stock, then show as “In stock” else “out of stock” in same row. 
                            if (cart.PurchaseCount < food.QuantityAvailable)
                            {
                                flaged = false;
                                System.Console.WriteLine($"FoodID:{food.FoodID,-15} | FoodName :{food.FoodName,-15} QuantityAvailable{food.QuantityAvailable,-15}| PriceperQuantity :{food.PricePerQuantity,-15} | In-Stock");
                                //Calculate TotalPrice of available stock items.*/
                                totalPrice += cart.PriceOfCart;
                            }
                            else
                            {
                                System.Console.WriteLine($"FoodID:{food.FoodID,-15} | FoodName :{food.FoodName,-15} QuantityAvailable{food.QuantityAvailable,-15}| PriceperQuantity :{food.PricePerQuantity,-15} | Out_Of-Stock");
                            }
                        }
                    }
                }
                if (flaged)
                {
                    System.Console.WriteLine("you have added No Items in the cart");
                }
                //1. If the customer has cartItems to purchase means, then check the current customer’s wallet balance meets the TotalPrice.
                if (currentLoginedCustomer.WalletBalance >= totalPrice)
                {
                    //3. If the customer has enough balance, then deduct the TotalPrice from the current customer’s wallet balance.
                    currentLoginedCustomer.DeductBalance(totalPrice);
                    //Create a booking object with BookingID (auto incremented), CustomerID, TotalPrice, DateOfBooking as now, BookingStatus as “Booked”.*/
                    BookingDetails booking = new BookingDetails(currentLoginedCustomer.CustomerID, totalPrice, DateTime.Now, BookingStatus.Booked);
                    //5. Create a string list to store cartItemIDs.
                    string cartItemIDs;
                    bookings.Add(booking);
                    bool flag=false;
                    PurchasedItem purchased1;
                    //. Traverse the cartItemsList. Find the PurchaseCount is available for the food by traversing foodsList.
                    foreach (CartDetails cart in carts)
                    {
                        foreach (FoodDetails food in foods)
                        {
                            if (currentLoginedCustomer.CustomerID.Equals(cart.CustomerID) && food.FoodID.Equals(cart.FoodID))
                            {
                                flag=true;
                                // If it is available, then deduct the food quantity
                                food.QuantityAvailable -= cart.PurchaseCount;
                                // Create purchasedItem entry for that cartItem and add it to purchasedItemsList.
                                PurchasedItem purchased = new PurchasedItem(booking.BookingID, cart.CartID, food.FoodID, cart.PurchaseCount, totalPrice);
                                //Add the purchased cartItem’s ID to the string list created in step 5.
                                purchaseds.Add(purchased);
                                purchased1=purchased;
                                cartItemIDs = purchased.CartID;
                                //. Add the created booking object to the bookings list, then show .
                                
                                // Remove purchased cartItems from the cartItemsList using cartItem’sID created in step 5.*/
                                //carts.RemoveAll(cart=>cartItemIDs.Contains(cart.CartID));
                                break;

                            }
                        }
                    }
                    if(flag)
                    {
                        System.Console.WriteLine($"“Booking Successful.");
                    }
                    carts.RemoveAll(cart => cart.CartID.Contains(cart.CartID));

                }

                else
                {
                    //2. If the customer doesn’t have enough balance, then show “Insufficient balance to make your purchase. Needed amount to make your purchase is ______”. Then,
                    System.Console.WriteLine($"Insufficient balance to make your purchase. Needed amount to make your purchase is {totalPrice - currentLoginedCustomer.WalletBalance}");
                    // Ask if the customer wish to recharge their wallet, If the customer chooses “No”, then show the PurchaseMenu Options.
                    System.Console.WriteLine("Do you want to recharge your wallet ?\nyes\nno");
                    string option = Console.ReadLine().ToUpper();
                    // If the customer chooses “Yes”, then get the recharge amount and recharge the wallet of the current customer.
                    if (option == "YES")
                    {
                        WalletRecharge();
                    }
                    else if (option == "NO")
                    {
                        Purchase();
                    }
                    // Again, check if the customer’s wallet balance meets the TotalPrice. If the balance is insufficient repeat steps “a and b”.*/
                    ConfirmPurchase();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }

        }
        public void ModifyCart()
        {
            try
            {
                if (carts.Count > 0)
                {
                    //1. Show all the cartItems details of the current customer.
                    foreach (CartDetails cart in carts)
                    {
                        if (cart.CustomerID.Equals(currentLoginedCustomer.CustomerID))
                        {

                            //1. Show all the cartItems of the current customer.
                            System.Console.WriteLine($"CartID :{cart.CartID,-15}| CustomerID :{cart.CustomerID,-15} | FoodID :{cart.FoodID,-15} | PurchaseCount :{cart.PurchaseCount,-15} | Price of the cart :{cart.PriceOfCart,-15}");
                        }
                    }
                    // Ask the customer to select one CartID, the customer wants to modify.
                    System.Console.WriteLine(" select one CartID, the customer wants to modify. ");
                    string currentCartID = Console.ReadLine().ToUpper();
                    bool flag = true;
                    foreach (CartDetails cart1 in carts)
                    {
                        //3. Validate if the CartID is valid.
                        if (currentCartID.Equals(cart1.CartID))
                        {
                            flag = false;
                            // If the CartID is valid, then ask the customer to enter the new PurchaseCount to update.
                            System.Console.WriteLine("enter the new PurchaseCount to update");
                            int count = Convert.ToInt32(Console.ReadLine());
                            // Update the chosen cartItem’s PurchaseCount and PriceOfCart for the selected new quantity, 
                            cart1.PurchaseCount = count;
                            foreach (FoodDetails food in foods)
                            {
                                if (cart1.FoodID.Equals(food.FoodID))
                                {
                                    cart1.PriceOfCart = count * food.PricePerQuantity;
                                }
                            }
                            //then show “Cart Modified Successfully”.*/
                            System.Console.WriteLine("Cart Modified Successfully");
                            break;
                        }
                    }
                    if (flag)
                    {
                        //If the CartID is invalid, then show “Invalid CartID” and show the PurchaseMenu Options.
                        System.Console.WriteLine("Invalid CartID...Plz enter the valid one");

                    }
                }
                else
                {
                    System.Console.WriteLine("No cart history found");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }

        }
        public void DeleteCart()
        {
            try
            {
                if (carts.Count > 0)
                {
                    foreach (CartDetails cart in carts)
                    {
                        //1. Show all the cartItems of the current customer.
                        if (cart.CustomerID.Equals(currentLoginedCustomer.CustomerID))
                        {

                            System.Console.WriteLine($"CartID :{cart.CartID,-15}| CustomerID :{cart.CustomerID,-15} | FoodID :{cart.FoodID,-15} | PurchaseCount :{cart.PurchaseCount,-15} | Price of the cart :{cart.PriceOfCart,-15}");
                        }
                    }
                    //2. Ask the customer to select one CartID, the customer wants to delete.
                    System.Console.WriteLine("Enter the CARTID you want to delete ");
                    string currentCartID = Console.ReadLine().ToUpper();
                    bool flag = true;
                    foreach (CartDetails cart1 in carts.ToList())
                    {
                        //3. Validate if the CartID is valid.
                        if (currentCartID.Equals(cart1.CartID))
                        {
                            flag = false;
                            carts.Remove(cart1);
                            System.Console.WriteLine("“Cart deleted successfully”");
                            break;
                        }
                    }
                    if (flag)
                    {
                        //If the CartID is invalid, then show “Invalid CartID” and show the PurchaseMenu Options.
                        System.Console.WriteLine("Invalid CartID...Plz enter the valid one");
                    }
                }
                else
                {
                    System.Console.WriteLine("No cart history found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occuered{e.Message}");
                Console.WriteLine($"An error occuered{e.StackTrace}");
            }
        }
    }
}