using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace BankApp
{
    public class UserDetails
    {
        private static int s_customerID = 1000;

        public String CustomerID { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public GenderDetails Gender { get; set; }

        public string PhoneNumber { get; set; }
        public string MailID { get; set; }
        public DateTime DOB { get; set; }

        public UserDetails(string customerName, double balance, GenderDetails gender, string phoneNumber, string mailID, DateTime dob)
        {
            CustomerID = $"HDFC{++s_customerID}";
            Balance = balance;
            Gender = gender;
            PhoneNumber = phoneNumber;
            MailID = mailID;
            DOB = dob;
        }

        public void Deposit(double deposit)
        {
            Balance += deposit;
            Console.WriteLine($"{deposit} Transaction successful. you balance after transaction is {Balance}");
        }
        public void WithDraw(Double withDraw)
        {
            if (withDraw > Balance)
            {
                Console.WriteLine("Insufficient Balance....");
            }
            else
            {
                Balance -= withDraw;
                Console.WriteLine($"Balance amount after transaction {Balance}");
            }
        }
    }
}