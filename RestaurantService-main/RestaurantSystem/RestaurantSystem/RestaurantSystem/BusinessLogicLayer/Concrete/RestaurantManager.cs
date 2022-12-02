using RestaurantSystem.BusinessLogicLayer.Abstract;
using RestaurantSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.BusinessLogicLayer.Concrete
{
    public class RestaurantManager : IRestaurantService
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantManager(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        public void Create(Restaurant restaurant)
        {
            try
            {
                if (restaurant!=null)
                {
                    _restaurantService.Create(restaurant);
                }
            }
            catch (Exception)
            {

                throw new Exception("Restoran yaradilmadi");
            }
        }

        public void GetAll()
        {
            try
            {
                _restaurantService.GetAll();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Restaurant GetRestaurantByName(string name)
        {
            _restaurantService.GetRestaurantByName(name);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
