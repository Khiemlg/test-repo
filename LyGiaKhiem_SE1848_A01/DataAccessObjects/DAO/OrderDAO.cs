using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace DataAccessObjects.DAO
{
    public class OrderDAO
    {
        private static List<Order> orderList = new();

        static OrderDAO()
        {
            orderList.Add(new Order { OrderID = 1, CustomerID = 3, EmployeeID = 2, OrderDate = DateTime.Now.AddDays(-15) });
            orderList.Add(new Order { OrderID = 2, CustomerID = 5, EmployeeID = 4, OrderDate = DateTime.Now.AddDays(-12) });
            orderList.Add(new Order { OrderID = 3, CustomerID = 2, EmployeeID = 1, OrderDate = DateTime.Now.AddDays(-9) });
            orderList.Add(new Order { OrderID = 4, CustomerID = 4, EmployeeID = 3, OrderDate = DateTime.Now.AddDays(-7) });
            orderList.Add(new Order { OrderID = 5, CustomerID = 6, EmployeeID = 5, OrderDate = DateTime.Now.AddDays(-4) });
            orderList.Add(new Order { OrderID = 6, CustomerID = 1, EmployeeID = 6, OrderDate = DateTime.Now.AddDays(-2) });
            orderList.Add(new Order { OrderID = 7, CustomerID = 7, EmployeeID = 7, OrderDate = DateTime.Now.AddDays(-1) });

        }

        public static List<Order> GetAll() => orderList;

        public static Order? GetById(int id) =>
            orderList.FirstOrDefault(o => o.OrderID == id);

        public static void Add(Order order)
        {
            order.OrderID = orderList.Any() ? orderList.Max(o => o.OrderID) + 1 : 1;
            orderList.Add(order);
        }

        public static List<Order> GetByCustomer(int customerId) =>
            orderList.Where(o => o.CustomerID == customerId).ToList();

        public static List<Order> GetByDateRange(DateTime from, DateTime to) =>
            orderList.Where(o => o.OrderDate.Date >= from.Date && o.OrderDate.Date <= to.Date)
                     .OrderByDescending(o => o.OrderDate).ToList();
    }
}
