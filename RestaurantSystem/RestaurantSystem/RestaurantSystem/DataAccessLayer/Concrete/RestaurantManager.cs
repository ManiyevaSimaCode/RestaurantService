using RestaurantSystem.DataAccessLayer.Abstracts;
using RestaurantSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer.Concrete
{
    public class RestaurantManager : BaseManager<Restaurant>, IRestaurantService<Restaurant>
    {
        
        public void GetAll()
        {
            
        }

        public void GetById(int id)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                if (restaurant.Id==id)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
