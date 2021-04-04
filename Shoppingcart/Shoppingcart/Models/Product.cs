using System;
namespace Shoppingcart.Models
{
    public class Product
    {
        public Product()
        {
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public int ProductPrice { get; set; }
    }
}
