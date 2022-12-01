using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Entity
{
    public class Restaurant:Base
    {
        public string Name { get; set; }
        public Product[] Products;
        public Restaurant(string name)
        {
            Name = name;
            Products = new Product[0];
        }
    }
}
