using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Entity
{
   public abstract class Base
    {
        static int _id = 1000;
        public int Id { get; }
        public Base()
        {
            _id++;
            Id = _id;
        }
    }
}
