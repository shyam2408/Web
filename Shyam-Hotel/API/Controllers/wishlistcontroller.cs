using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelAPI.Models;
namespace HotelAPI.Controllers
{
    [ApiController]
    [Route("api/hotel/wishlistcontroller/")]
    public class wishlistcontroller : ControllerBase
    {
        [HttpGet("carts/{customerID}")]

        public IActionResult GetCarts(string customerID)
        {
            List<Wishlist> wishlistList = new List<Wishlist>();
            ApplicationDBContext.wishlists.ForEach(wishlist =>
            {
                if (wishlist.CustomerID == customerID)
                {
                    wishlistList.Add(wishlist);
                }
            });
            return Ok(wishlistList);
        }

        [HttpPost("add/cartItem")]

        public IActionResult AddNewCart([FromBody] Wishlist wishlist)
        {
            wishlist.WishlistID = "WSID" + (4001 + ApplicationDBContext.wishlists.Count);
            ApplicationDBContext.wishlists.Add(wishlist);
            return Ok(wishlist.WishlistID);
        }
        [HttpPut("update/cart/{customerID}/{wishlistID}/{startdate}/{enddate}")]

        public IActionResult UpdateCartQuantity(string customerID, string wishlistID, string startdate,string enddate)
        {
            var cart = ApplicationDBContext.wishlists.FirstOrDefault(cart => cart.WishlistID == wishlistID && cart.CustomerID == customerID);
         
            if (cart == null)
            {
                return NotFound();
            }
            cart.StayingFrom = DateTime.Parse(startdate);
            cart.StayingTo = DateTime.Parse(enddate);
            var product = ApplicationDBContext.roomItems.FirstOrDefault(product => product.RoomID == cart.RoomID);
            if (product == null)
            {
                return NotFound();
            }
           

            cart.PriceOfRoom = (cart.StayingTo-cart.StayingFrom).Days * product.PricePerDay;
            return Ok();
        }

        [HttpDelete("delete/newcart/{customerID}/{wishlistID}")]
        public IActionResult DeleteTempOrder(string customerID, string wishlistID)
        {
            
            var cart = ApplicationDBContext.wishlists.Find(cart => cart.WishlistID == wishlistID && cart.CustomerID == customerID);
            
            if (cart == null)
            {
                return NotFound();
            }
            ApplicationDBContext.wishlists.Remove(cart);
            return Ok();
        }
    }
}