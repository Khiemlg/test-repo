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
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public List<OrderDetail> GetByOrderId(int orderId) => OrderDetailDAO.GetByOrderId(orderId);
        public void Add(OrderDetail detail) => OrderDetailDAO.Add(detail);
        public void DeleteByOrderId(int orderId) => OrderDetailDAO.DeleteByOrderId(orderId);
    }
}
