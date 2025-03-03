using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GroceryWebAPI.Models;

namespace GroceryWebAPI.Controllers
{
    [ApiController]
    [Route("api/grocerystore/productscontroller/")]
    public class ProductDetailsController : ControllerBase
    {
        [HttpGet("products")]

        public IActionResult GetProducts()
        {
            return Ok(ApplicationDBContext.products);
        }

        //getting the product
        [HttpGet("get/product/{productID}")]
        public IActionResult GetProductDetail(string productID)
        {
            var product = ApplicationDBContext.products.FirstOrDefault(product => product.ProductID == productID);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //Adding new product
        [HttpPost("add/newProduct")]

        public IActionResult AddNewProduct([FromBody] ProductDetails product)
        {
            product.ProductID = "PID" + (ApplicationDBContext.products.Count + 2001);
            ApplicationDBContext.products.Add(product);
            return Ok(product.ProductID);
        }

        //checking if the product already exists
        [HttpGet("product/{productName}")]

        public IActionResult GetProductExist(string productName)
        {
            bool isProductValid = ApplicationDBContext.products.Any(product => product.ProductName.ToLower() == productName.ToLower());
            return Ok(isProductValid);
        }

        [HttpPut("new/prod/edit")]
        public IActionResult EditProduct(ProductDetails product)
        {
            var prod = ApplicationDBContext.products.FirstOrDefault(prod => prod.ProductID == product.ProductID);
            if (product == null)
            {
                return NotFound();
            }
            prod.ProductName = product.ProductName;
            prod.PricePerQuantity = product.PricePerQuantity;
            prod.QuantityAvailable = product.QuantityAvailable;
            prod.ProductImage = product.ProductImage;
            return Ok();
        }

        [HttpDelete("delete/{productID}")]
        public IActionResult DeleteProduct(string productID)
        {
            var product = ApplicationDBContext.products.Find(product => product.ProductID == productID);
            if (product == null)
            {
                return NotFound();
            }
            ApplicationDBContext.products.Remove(product);
            return Ok();
        }
    }
}