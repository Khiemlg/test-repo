using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace Repositories.Repositories.Interfaces
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetByOrderId(int orderId);
        void Add(OrderDetail detail);
        void DeleteByOrderId(int orderId);
    }
}
