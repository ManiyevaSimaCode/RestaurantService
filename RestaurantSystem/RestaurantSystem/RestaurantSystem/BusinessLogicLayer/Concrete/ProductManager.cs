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
        private readonly ProductManager _productManager;
        public ProductManager(ProductManager productManager)
        {
            _productManager = productManager;
        }
    
        public void Create(Product entity)
        {

            try
            {
                if (entity!=null)
                {
                    _productManager.Create(entity);

                }
            }
            catch (Exception)
            {

                throw new Exception("Elave edilmedi");
            }
        }

        public void Remove(int id)
        {
            try
            {
                _productManager.Remove(id);
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
                _productManager.Update(id);
            }
            catch (Exception)
            {

                throw new Exception("Update olundu");
            }
        }
    }
}
