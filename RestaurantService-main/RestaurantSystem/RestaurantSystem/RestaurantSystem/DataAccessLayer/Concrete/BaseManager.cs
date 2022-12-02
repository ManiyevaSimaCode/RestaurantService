using RestaurantSystem.DataAccessLayer.Abstracts;
using RestaurantSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer.Concrete
{
    public class BaseManager :IBaseService
    {
        public void Remove(int id)
        {
            //for (int i = 0; i < values.Length; i++)
            //{
            //    int item =Convert.ToInt32(values[id]);

            //    values = Array.FindAll(values, i => i != item).ToArray();
            //}
        }

        public void Update(int id)
        {
            
        }
    }
}
