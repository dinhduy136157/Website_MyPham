using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website_MyPham.Models
{
    public class Product
    {
        public int product_id { get; set; }
        public string SKU { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public int Category_catego { get; set; }
        public Product()
        {

        }
        public Product(int product_id, string sKU, string description, decimal price, int stock, int category_catego)
        {
            this.product_id = product_id;
            SKU = sKU;
            this.description = description;
            this.price = price;
            this.stock = stock;
            Category_catego = category_catego;
        }
    }
}