using RestaurantSystem.DataAccessLayer.Abstracts;
using RestaurantSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer.Concrete
{
    public class ProductManager : BaseManager, IProductService

    {
        RestaurantManager restaurantManager = new RestaurantManager();
       public static Product[] products;

        public void Create(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
            
        }

     

        public void GetAll(string name)
        {
            foreach (var product in restaurantManager.GetRestaurantByName(name))
            {

            }
        }

        public void GetByNameInRestaurant(string name)
        {
           
        }
    }
}
