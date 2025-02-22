using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncart;

namespace E_CommerceApplicationforConsumerElectronicsProducts
{
    public class Operations
    {
        //creating list to store 
        List<CustomerClassDetails> customers = new List<CustomerClassDetails>();
        //creating list to store 
        List<ProductDetails> products = new List<ProductDetails>();
        //creating cookie to get current object
        CustomerClassDetails currentLoggedCustomer;
        ////creating list to store 
        List<OrderDetails> orders = new List<OrderDetails>();

        public void Default()

        {
            //storinig default values to the list
            CustomerClassDetails customer1 = new CustomerClassDetails("Ravi", "Chennai", "9885858588", 50000, "ravi@mail.com");
            CustomerClassDetails customer2 = new CustomerClassDetails("Baskaran", "Chennai", "9888475757", 60000, "baskaran@mail.com");
            customers.AddRange(new List<CustomerClassDetails>() { customer1, customer2 });
            ////storinig default values to the list
            ProductDetails product1 = new ProductDetails("PID2001", "Mobile (Samsung)", 10, 10000, 3);
            ProductDetails product2 = new ProductDetails("PID2002", "Tablet (Lenovo)", 5, 15000, 2);
            ProductDetails product3 = new ProductDetails("PID2003", "Camara (Sony)", 3, 20000, 4);
            ProductDetails product4 = new ProductDetails("PID2004", "iPhone", 5, 50000, 6);
            ProductDetails product5 = new ProductDetails("PID2005", "Laptop (Lenovo I3)", 3, 40000, 3);
            ProductDetails product6 = new ProductDetails("PID2006", "HeadPhone (Boat)", 5, 1000, 2);
            ProductDetails product7 = new ProductDetails("PID2007", "Speakers (Boat)", 4, 500, 2);

            products.AddRange(new List<ProductDetails>() { product1, product2, product3, product4, product5, product6, product7 });


            ////storinig default values to the list
            OrderDetails order1 = new OrderDetails("CID3001", "PID2001", 20000, DateTime.Now, 2, OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("CID3002", "PID2003", 40000, DateTime.Now, 2, OrderStatus.Ordered);
            orders.AddRange(new List<OrderDetails>() { order1, order2 });

        }


        public void MainMenu()
        {
            //creating bool value
            bool flag = true;
            do
            {
                //getting or showing main menu to the user
                Console.WriteLine("Main menu:\n1.Customer Registration\n2.Login\n4.Exit");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
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
                            Console.WriteLine("Exit the application.......");
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        //method for the registration process
        public void Registration()
        {
            //getting inputs from the user
            Console.WriteLine("Enter Your CustomerName:");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter Your city:");
            string city = Console.ReadLine();
            Console.WriteLine("enter your phone number :");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine("Enter your Walletbalnce :");
            double walletBalance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your EmailId:");
            string eMailID = Console.ReadLine();
            CustomerClassDetails customer = new CustomerClassDetails(customerName, city, mobileNumber, walletBalance, eMailID);
            //displaying successfull message and customerID to the user
            Console.WriteLine("Registration Successful your CustomerID is " + customer.CustomerID);
            //adding customer details to the list
            customers.Add(customer);
        }
        //method for Login operation
        public void Login()
        {
            Console.WriteLine("User Login........");
            Console.WriteLine("Enter your CustomerID: ");
            string userEnteredCustomerID = Console.ReadLine().ToUpper();
            //setting flag to end for loop to avoid overide
            bool flag = true;
            foreach (CustomerClassDetails customer in customers)
            {
                //if the user id and customerid mathches display successfull message and change flag
                if (userEnteredCustomerID.Equals(customer.CustomerID))
                {
                    Console.WriteLine("Login Successful......");
                    //changing the flag and end the loop  for optimization
                    flag = false;
                    currentLoggedCustomer = customer;
                    //calling the submenu
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid User...Please enter a valid user.....");
            }
        }

        public void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Enter your Choice \nPurchase \nOrderHistory \nCancelOrder \nWalletBalance  \nWalletRecharge \nExit ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Purchase();
                            break;
                        }
                    case 2:
                        {
                            OrderHistory();
                            break;
                        }
                    case 3:
                        {
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            WalletBalance();
                            break;
                        }
                    case 5:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Exit the application.....");
                            flag = false;
                            break;
                        }
                }
            } while (flag);

        }

        public void Purchase()
        {
            System.Console.WriteLine("Purchase........");
            //show the list of prodeucts from the product list 

            foreach (ProductDetails product in products)
            {

                Console.WriteLine($"|{product.ProductID,-15} | {product.ProductName,-15} | {product.Price,-15} | {product.Stock,-15} | {product.ShippingDuration,-15} |");
            }
            Console.WriteLine("Enter the productID you want to purchase: ");
            //ask and get product id
            //validate productid if valid show valid productid
            String productID = Console.ReadLine();
            bool flag = true;
            foreach (ProductDetails product in products)
            {
                if (product.ProductID.Equals(productID))
                {
                    flag = false;
                    Console.WriteLine("Valid ProductID");
                    //if id is valid ask and get a requiered count
                    Console.WriteLine("enter the number of count you want");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    //check product quantity if quantity is not available then shwo not availavble
                    if (product.Stock >= quantity)
                    {
                        //if the peoduct is availabe -- calculate the total price
                        double totalPrice = quantity * product.Price;
                        //check the user balance --check he has balance if not show insufficient balance recharge and proceed order
                        if (currentLoggedCustomer.WalletBalance >= totalPrice)
                        {
                            //if he has balance deutct amount
                            currentLoggedCustomer.DeductBalance(totalPrice);
                            //reduce stock count
                            product.Stock -= quantity;
                            //create order object and to list
                            OrderDetails order = new(currentLoggedCustomer.CustomerID, product.ProductID, totalPrice, DateTime.Now, quantity, OrderStatus.Ordered);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance Recahrge for further step");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not Available");
                    }
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid ProdeuctID");
            }
            //shwo dekiverry date by calculating peoduct shipping duration with current date 
            //show order placed successfully and show the order id
        }
        //method for order history
        public void OrderHistory()
        {
            System.Console.WriteLine("OrderHistry......");
            bool flag = true;
            foreach (OrderDetails order in orders)
            {
                //checking current customer ID with user entered customerID
                if (order.CustomerID.Equals(currentLoggedCustomer.CustomerID))
                {
                    flag = false;
                    Console.WriteLine($"| {order.OrderID,-15} | {order.ProductID,15} | {order.ProductID,-15} | {order.PurchaseDate,15} | {order.TotalPrice,-15}");
                }
            }
            if (flag)
            {
                //if not no histories found
                System.Console.WriteLine("no order histories found");
            }

        }
        public void CancelOrder()
        {
            System.Console.WriteLine("Cancel Order.......");
            //travese and show order histrory of current user whose order sstatus are booked
            bool flag = true;
            foreach (OrderDetails order in orders)
            {
                if (currentLoggedCustomer.CustomerID.Equals(order.CustomerID) && order.Status.Equals(OrderStatus.Ordered))
                {
                    Console.WriteLine($"|{order.OrderID,-15} | {order.ProductID,-15} | {order.PurchaseDate,-15} |");
                    flag = false;
                }
            }
            if (flag)
            {
                //if no order history found display
                Console.WriteLine("Enter the order id if you want to be cancel...");
                string orderID = Console.ReadLine().ToUpper();
                bool orderFlag = true;
                foreach (OrderDetails order in orders)
                {
                    //change the order status to be dcanscelled
                    if (orderID.Equals(order.OrderID) && order.Status.Equals(OrderStatus.Ordered))
                    {
                        orderFlag = false;
                        //valitdate if orderid is valid return the products in order list to product list 
                        foreach (ProductDetails product in products)
                        {
                            if (product.ProductID.Equals(order.ProductID))
                            {
                                //return the purchased amount to the user 
                                product.Stock += order.Quantity;
                                currentLoggedCustomer.WalletRecharge(order.TotalPrice);
                                order.Status = OrderStatus.Canceled;

                            }
                        }
                        break;
                    }
                }
                if (orderFlag)
                {
                    //show order cancelled successfully
                    Console.WriteLine("Invalid OrderID:");
                }
            }
        }
        public void WalletBalance()
        {
            //method for wallet balance
            System.Console.WriteLine("Wallet Balance.......");
            Console.WriteLine("your balance " + currentLoggedCustomer.WalletBalance);
        }
        public void WalletRecharge()
        {
            System.Console.WriteLine("Wallet Recharge.......");
            Console.WriteLine("Enter amount to recharge:");
            double amount = Convert.ToInt64(Console.ReadLine());
            //checking wallet amount is greater than o
            if (amount > 0)
            {
                currentLoggedCustomer.WalletRecharge(amount);
            }
            else
            {
                //if it is error messages
                Console.WriteLine("Insufficient balance");
            }
        }

    }

}