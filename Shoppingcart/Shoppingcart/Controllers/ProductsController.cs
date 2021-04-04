using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shoppingcart.Models;

namespace Shoppingcart.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult GetAllProducts(string productName)
        {
            IList<Product> productList = new List<Product>();

            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Revolvers";
            product1.ProductDescription = "Hand Held Gun";
            product1.ProductImage = "Image 1";
            product1.ProductPrice = 200;
            productList.Add(product1);


            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Semi-Auto Pistols";
            product2.ProductDescription = "Hand Held Gun";
            product2.ProductImage = "Image 2";
            product2.ProductPrice = 300;
            productList.Add(product2);


            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductName = "Rifles";
            product3.ProductDescription = "Long Gun";
            product3.ProductImage = "Image 3";
            product3.ProductPrice = 350;
            productList.Add(product3);


            Product product4 = new Product();
            product4.ProductId = 4;
            product4.ProductName = "Shot Guns";
            product4.ProductDescription = "Two Gauge";
            product4.ProductImage = "Image 4";
            product4.ProductPrice = 400;
            productList.Add(product4);


            Product product5 = new Product();
            product5.ProductId = 5;
            product5.ProductName = "Machine Guns";
            product5.ProductDescription = "Fully Automatic";
            product5.ProductImage = "Image 5";
            product5.ProductPrice = 600;
            productList.Add(product5);

            return View(productList);
        }
    }
}
