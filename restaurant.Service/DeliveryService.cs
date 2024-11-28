using restaurant.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Service
{
    public class DeliveryService : IDeliveryService
    {
        private IDeliveryRepository _deliveryRepository;
        public DeliveryService(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }
        public List<Delivery> GetDeliveries()
        {
            return _deliveryRepository.Get();
        }
        public Delivery GetDeliveryById(int id)
        {
            return _deliveryRepository.Get(id);
        }
        public Delivery Post(Delivery delivery)
        {
            return _deliveryRepository.Post(delivery);
        }
        public Delivery Put(int id, Delivery delivery)
        {
            return _deliveryRepository.Put(id, delivery);
        } 
        public void Delete(int id)
        {
            _deliveryRepository.Delete(id);
        }
    }
}
