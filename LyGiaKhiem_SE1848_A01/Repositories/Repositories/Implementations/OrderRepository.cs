using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using DataAccessObjects.DAO;
using Repositories.Repositories.Interfaces;

namespace Repositories.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetOrders() => OrderDAO.GetAll();
        public Order? GetById(int id) => OrderDAO.GetById(id);
        public void Add(Order order) => OrderDAO.Add(order);
        public List<Order> GetByCustomer(int customerId) => OrderDAO.GetByCustomer(customerId);
        public List<Order> GetByDateRange(DateTime from, DateTime to) => OrderDAO.GetByDateRange(from, to);
    }
}
