using RestaurantSystem.DataAccessLayer.Abstracts;
using RestaurantSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer.Concrete
{
    public class RestaurantManager : BaseManager, IRestaurantService
    {
        public static Restaurant[] restaurants;

        public void Create(Restaurant restaurant)
        {
            Array.Resize(ref restaurants, restaurants.Length + 1);
            restaurants[restaurants.Length - 1] = restaurant;
        }

        public void GetAll()
        {
            foreach (var restaurant in restaurants)
            {
                Console.WriteLine($"{restaurant.Id}------{restaurant.Name}-------");
            }
        }

        public void GetById(int id)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                if (restaurant.Id == id)
                {
                    Console.WriteLine("");
                }
            }
        }

        public Restaurant[] GetRestaurantByName(string name)
        {
            foreach (var restaurant in RestaurantManager.restaurants)
            {
                if (restaurant[].Name == name)
                {

                    return restaurant[];
                }

            }
            return null;

        }
    }
}
