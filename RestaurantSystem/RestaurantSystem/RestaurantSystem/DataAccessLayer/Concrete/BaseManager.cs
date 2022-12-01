using RestaurantSystem.DataAccessLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer.Concrete
{
    public class BaseManager<T> :IBaseService<T>
    {
        public static T[] values;
        public void Create(T entity)
        {
            Array.Resize(ref values, values.Length + 1);
            values[values.Length-1]=entity;
        }

     

        public void Remove(int id)
        {
            
        }

        public void Update(int id)
        {
            
        }
    }
}
