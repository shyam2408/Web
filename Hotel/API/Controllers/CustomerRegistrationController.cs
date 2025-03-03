using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroceryWebAPI.Models;

namespace GroceryWebAPI.Controllers
{
    [ApiController]
    [Route("api/grocerystore/customercontroller/")]
    public class CustomerRegistrationController : ControllerBase
    {
        //checking if mail id already exists
        [HttpGet("{mailID}")]

        public IActionResult GetIndividualUser(string mailID)
        {
            bool isCustomerValid = ApplicationDBContext.customers.Any(user => user.MailID == mailID.ToLower());
            return Ok(isCustomerValid);
        }

        //getting the sign in user
        [HttpGet("{mailID}/{password}")]
        public IActionResult GetUser(string mailID, string password)
        {
            var user = ApplicationDBContext.customers.FirstOrDefault(user => user.MailID == mailID.ToLower() && user.Password == password);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        //adding new user
        [HttpPost("newUser/{customer}")]
        public IActionResult AddNewUser([FromBody] CustomerRegistration customer)
        {
            // Generate a unique customer ID by incrementing an auto-incrementing ID
            customer.CustomerID = "CID" + (ApplicationDBContext.customers.Count + 1001);
            ApplicationDBContext.customers.Add(customer);
            return Ok(customer.CustomerID); // Return the added customer to confirm
        }

        [HttpPut("recharge/{customerID}/{amount}")]
        public IActionResult RechargeWalletBalance(string customerID, double amount)
        {
            var user = ApplicationDBContext.customers.FirstOrDefault(user => user.CustomerID == customerID);
            if (user == null)
            {
                return NotFound();
            }
            user.WalletBalance += amount;
            return Ok();
        }
    }
}