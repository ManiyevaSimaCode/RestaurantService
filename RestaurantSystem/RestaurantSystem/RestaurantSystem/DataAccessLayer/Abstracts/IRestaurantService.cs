using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer.Abstracts
{
    public interface IRestaurantService<Restaurant>:IBaseService<Restaurant>
    {
        void GetAll();
        void GetById(int id);
        
    }
}
