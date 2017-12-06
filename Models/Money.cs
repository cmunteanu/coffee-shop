using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Money
    {
        public double Amount { get; set; }
        public string Currency { get; set; }

        public string GetFormattedValue()
        {
            return this.Amount + " " + this.Currency; 
        }

        public Money(double amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }
    }
}
