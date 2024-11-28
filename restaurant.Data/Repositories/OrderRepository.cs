using restaurant.Core.enties;
using restaurant.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        static int counter = 0;
        private DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public List<Order> GetAll()
        {
            return _context.orders.ToList();
        }
        public Order GetById(int id)
        {
            int index = _context.orders.ToList().FindIndex(o => o.OrderId == id);
            return _context.orders.ToList()[index];
        }
        public Order Post(Order order)
        {
            order.OrderId = counter++;
            _context.orders.Add(order);
            return order;
        }
        public Order Update(int id, Order order)
        {
            int index = _context.orders.ToList().FindIndex(o => o.OrderId == id);
            _context.orders.ToList()[index].OrderDate = order.OrderDate;
            _context.orders.ToList()[index].OrderStatus = order.OrderStatus;
            _context.orders.ToList()[index].TotalCost = order.TotalCost;
            return _context.orders.ToList()[index];
        }
        public void Delete(int id)
        {
            int index = _context.orders.ToList().FindIndex(o => o.OrderId == id);
            _context.orders.ToList().Remove(_context.orders.ToList()[index]);
        }
    }
}
