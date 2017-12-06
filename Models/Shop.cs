using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Shop
    {
        public List<Category> CategoryList { get; set; }

        public List<Product> ProductList { get; set; }

        public Shop()
        {
            this.CategoryList = new List<Category>();
            this.ProductList = new List<Product>();
        }

        public Shop(string fileName)
        {
            this.CategoryList = new List<Category>();
            this.ProductList = new List<Product>();
        }
    }
}
