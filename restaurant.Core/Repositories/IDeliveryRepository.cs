using restaurant.Core.enties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Core.Repositories
{
    public interface IDeliveryRepository
    {
        public List<Delivery> Get();
        public Delivery Get(int id);
        public Delivery Post(Delivery delivery);
        public Delivery Put(Delivery delivery);
        public Delivery Delete(int id);

    }
}
