using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public Money FullPrice { get; set; }
        public Money ReducedPrice { get; set; }
        public int Quantity { get; set; }
        public int WeightInGrams { get; set; }

    }
}
