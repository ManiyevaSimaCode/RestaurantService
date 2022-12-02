using RestaurantSystem.BusinessLogicLayer.Abstract;
using RestaurantSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.BusinessLogicLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductService _productService;
        public ProductManager(IProductService productService)
        {
            _productService = productService;
        }
    
        public void Create(Product product)
        {
            try
            {
                if (product!=null)
                {
                    _productService.Create(product);

                }
            }
            catch (Exception)
            {
                throw new Exception("Elave edilmedi");
            }
        }


        public void GetAll(string name)
        {
            _productService.GetAll();
        }

        public void GetByNameInRestaurant(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            try
            {
                _productService.Remove(id);
            }
            catch (Exception)
            {

                throw new Exception("Silinmedi");
            }
        }

        public void Update(int id)
        {
            try
            {
                _productService.Update(id);
            }
            catch (Exception)
            {

                throw new Exception("Update olundu");
            }
        }
    }
}
