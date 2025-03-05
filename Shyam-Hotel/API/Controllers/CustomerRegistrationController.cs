using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelAPI.Models;
namespace HotelAPI.Controllers
{
     [ApiController]
    [Route("api/hotel/customercontroller/")]
    public class CustomerRegistrationController:ControllerBase
    {
         [HttpGet ("{mailID}")]
        public IActionResult GetIndividualUser(string mailID)
        {
            bool isCustomerValid = ApplicationDBContext.customers.Any(user => user.MailID == mailID.ToLower());
            
            return Ok(isCustomerValid);
        }
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
     
        [HttpPost("newUser/{customer}")]
        public IActionResult AddNewUser([FromBody] CustomerRegistration customer)
        {
            customer.CustomerID = "CID" + (ApplicationDBContext.customers.Count + 1001);
            ApplicationDBContext.customers.Add(customer);
            return Ok(customer.CustomerID); 
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