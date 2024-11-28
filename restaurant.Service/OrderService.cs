using restaurant.Core.enties;
using restaurant.Core.Repositories;
using restaurant.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Service
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> GetOrders()
        {
            return _orderRepository.GetAll();
        }
        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }
        public Order Post(Order order)
        {
            return _orderRepository.Post(order);
        }
        public Order Update(int id, Order order)
        {
            return _orderRepository.Update(id, order);
        }
        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }
    }
}
