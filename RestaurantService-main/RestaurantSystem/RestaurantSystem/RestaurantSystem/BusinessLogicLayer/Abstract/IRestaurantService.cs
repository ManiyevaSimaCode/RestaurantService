using RestaurantSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.BusinessLogicLayer.Abstract
{
    public interface IRestaurantService:IBaseService
    {
        void Create(Restaurant restaurant);

        void GetAll();
        void GetById(int id);
        Restaurant GetRestaurantByName(string name);

    }
}
