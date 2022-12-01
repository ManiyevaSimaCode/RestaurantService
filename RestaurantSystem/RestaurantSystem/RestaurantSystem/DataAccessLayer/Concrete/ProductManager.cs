using RestaurantSystem.DataAccessLayer.Abstracts;
using RestaurantSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer.Concrete
{
    public class ProductManager : BaseManager<Product>, IProductService<Product>

    {
        Product[] products;
        public void GetAll(string name)
        {
            throw new NotImplementedException();
        }

        public void GetByNameInRestaurant(string name)
        {
            foreach (var product in products)
            {
                if (name==product)
                {

                }
            }
        }
    }
}
