using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Entity
{
    public class Product : Base
    {
        public string Name { get; set; }
        public double Price { get; set; }
        private double _discountedPrice;

        public double DiscountedPrice
        {
            get => _discountedPrice; set
            {
                if (value == 0)
                {
                    _discountedPrice = Price;
                    Price = value;
                }
            }
        }

        public Product(string name, double price, double discountedPrice)
        {
            Name = name;
            Price = price;
            DiscountedPrice = discountedPrice;
        }
    }
}
