using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace Services.Services.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        Order? GetById(int id);
        void Add(Order order);
        List<Order> GetByCustomer(int customerId);
        List<Order> GetByDateRange(DateTime from, DateTime to);
    }
}
