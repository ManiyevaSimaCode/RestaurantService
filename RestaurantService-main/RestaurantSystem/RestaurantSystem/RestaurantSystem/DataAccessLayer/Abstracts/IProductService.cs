using RestaurantSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer.Abstracts
{
    public interface IProductService: IBaseService

    {
        void Create(Product product);

        void GetAll(string name);
        void GetByNameInRestaurant(string name);
    }
    
}
