using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryWebAPI.Models;

namespace GroceryWebAPI.Controllers
{
    public class ApplicationDBContext
    {
        public static List<CustomerRegistration> customers = new List<CustomerRegistration>()
        {
            new CustomerRegistration{ CustomerID = "CID1001", Name = "Shyam", FatherName = "0709249837398", DOB = new DateTime(2005,06,22), Gender = "Male", MailID = "saravanan@gmail.com", MobileNumber = "8347484894", Password = "Saravana@123", WalletBalance = 1000, ProfilePhoto = "Images/ProfilePic.png"}
        };

        public static List<ProductDetails> products = new List<ProductDetails>()
        {
            new ProductDetails{ ProductID = "RID2001", ProductName = "Standard", QuantityAvailable = 2, PricePerQuantity = 500, ProductImage = "Images/Screenshot 2025-02-28 103225.png"},
            new ProductDetails{ ProductID = "RID2002", ProductName = "Standard", QuantityAvailable = 4, PricePerQuantity = 700, ProductImage = "Images/Screenshot 2025-02-28 103235.png"},
            new ProductDetails{ ProductID = "RID2003", ProductName = "Standard", QuantityAvailable = 2, PricePerQuantity = 500, ProductImage = "Images/Screenshot 2025-02-28 103248.png"},
            new ProductDetails{ ProductID = "RID2004", ProductName = "Standard", QuantityAvailable = 2, PricePerQuantity = 500, ProductImage = "Images/Screenshot 2025-02-28 103304.png"},
            new ProductDetails{ ProductID = "RID2005", ProductName = "Standard", QuantityAvailable = 2, PricePerQuantity = 500, ProductImage = "Images/Screenshot 2025-02-28 103321.png"},
            new ProductDetails{ ProductID = "RID2006", ProductName = "Delux", QuantityAvailable = 4, PricePerQuantity = 1000, ProductImage = "Images/Screenshot 2025-02-28 103334.png"},
            new ProductDetails{ ProductID = "RID2007", ProductName = "Delux", QuantityAvailable = 2, PricePerQuantity = 1000, ProductImage = "Images/Screenshot 2025-02-28 103350.png"},
            new ProductDetails{ ProductID = "RID2008", ProductName = "Delux", QuantityAvailable = 2, PricePerQuantity = 1400, ProductImage = "Images/Screenshot 2025-02-28 103356.png"},
            new ProductDetails{ ProductID = "RID2009", ProductName = "Delux", QuantityAvailable = 4, PricePerQuantity = 1400, ProductImage = "Images/Screenshot 2025-02-28 103225.png"},
            new ProductDetails{ ProductID = "RID2010", ProductName = "Suit", QuantityAvailable = 2, PricePerQuantity = 2000, ProductImage = "Images/Screenshot 2025-02-28 103304.png"},
            new ProductDetails{ ProductID = "RID2011", ProductName = "Suit", QuantityAvailable = 2, PricePerQuantity = 2000, ProductImage = "Images/Screenshot 2025-02-28 103235.png"},
            new ProductDetails{ ProductID = "RID2012", ProductName = "Suit", QuantityAvailable = 2, PricePerQuantity = 2000, ProductImage = "Images/Screenshot 2025-02-28 103248.png"},
            new ProductDetails{ ProductID = "RID2013", ProductName = "Suit", QuantityAvailable = 4, PricePerQuantity = 2500, ProductImage = "Images/Screenshot 2025-02-28 103334.png"}
        };

        public static List<BookingDetails> bookings = new List<BookingDetails>();
    }
}