
using RestaurantSystem.BusinessLogicLayer.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.BusinessLogicLayer.Concrete
{

    public class BaseManager : IBaseService
    {
        private IBaseService _baseService;

        public BaseManager(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public void Remove(int id)
        {
            _baseService.Remove(id);
        }

        public void Update(int id)
        {
            _baseService.Update(id);
        }
    }
}

