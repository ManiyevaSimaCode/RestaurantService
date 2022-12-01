using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.BusinessLogicLayer.Abstract
{
    public interface IBaseService<T>
    {
        void Create(T entity);
        void Remove(int id);
        void Update(int id);
       
    }
}
