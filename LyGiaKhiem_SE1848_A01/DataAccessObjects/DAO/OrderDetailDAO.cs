using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace DataAccessObjects.DAO
{
    public class OrderDetailDAO
    {
        private static List<OrderDetail> detailList = new();

        static OrderDetailDAO()
        {
            detailList.Add(new OrderDetail { OrderID = 1, ProductID = 4, UnitPrice = 1200, Quantity = 1, Discount = 0.0f });
            detailList.Add(new OrderDetail { OrderID = 1, ProductID = 5, UnitPrice = 750, Quantity = 2, Discount = 0.15f });
            detailList.Add(new OrderDetail { OrderID = 2, ProductID = 2, UnitPrice = 500, Quantity = 3, Discount = 0.1f });
            detailList.Add(new OrderDetail { OrderID = 3, ProductID = 6, UnitPrice = 200, Quantity = 4, Discount = 0.05f });
            detailList.Add(new OrderDetail { OrderID = 4, ProductID = 1, UnitPrice = 1500, Quantity = 1, Discount = 0.2f });
            detailList.Add(new OrderDetail { OrderID = 5, ProductID = 7, UnitPrice = 300, Quantity = 2, Discount = 0.0f });
            detailList.Add(new OrderDetail { OrderID = 6, ProductID = 3, UnitPrice = 20, Quantity = 10, Discount = 0.1f });

        }

        public static List<OrderDetail> GetByOrderId(int orderId) =>
            detailList.Where(d => d.OrderID == orderId).ToList();

        public static void Add(OrderDetail detail) => detailList.Add(detail);

        public static void DeleteByOrderId(int orderId)
        {
            detailList.RemoveAll(d => d.OrderID == orderId);
        }
    }
}
