using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using System.Xml.Linq;

namespace DataAccessObjects.DAO
{
    public class CustomerDAO
    {
        private static List<Customer> customerList = new();

        static CustomerDAO()
        {
            customerList.Add(new Customer
            {
                CustomerID = 1,
                CompanyName = "VinGroup",
                ContactName = "Pham Nhat Minh",
                ContactTitle = "Director",
                Address = "72 Le Thanh Tong, Ha Noi",
                Phone = "0909000111"
            });
            customerList.Add(new Customer
            {
                CustomerID = 2,
                CompanyName = "Samsung Vietnam",
                ContactName = "Kim Seok Jin",
                ContactTitle = "Sales Manager",
                Address = "12 Nguyen Van Linh, Bac Ninh",
                Phone = "0988123456"
            });
            customerList.Add(new Customer
            {
                CustomerID = 3,
                CompanyName = "TH Group",
                ContactName = "Hoang Thi Lan",
                ContactTitle = "Marketing Head",
                Address = "98 Phan Dang Luu, Nghe An",
                Phone = "0911002233"
            });
            customerList.Add(new Customer
            {
                CustomerID = 4,
                CompanyName = "VinaMilk",
                ContactName = "Nguyen Thi Hoa",
                ContactTitle = "Executive",
                Address = "102 Tan Binh, HCM",
                Phone = "0933445566"
            });
            customerList.Add(new Customer
            {
                CustomerID = 5,
                CompanyName = "Petrolimex",
                ContactName = "Tran Duy Kien",
                ContactTitle = "Deputy Manager",
                Address = "15 Hai Ba Trung, Ha Noi",
                Phone = "0977332211"
            });
            customerList.Add(new Customer
            {
                CustomerID = 6,
                CompanyName = "Shopee Vietnam",
                ContactName = "Pham Ngoc Bao",
                ContactTitle = "Accountant",
                Address = "88 Nguyen Hue, HCM",
                Phone = "0944556677"
            });
            customerList.Add(new Customer
            {
                CustomerID = 7,
                CompanyName = "Lazada Vietnam",
                ContactName = "Le Minh Chau",
                ContactTitle = "Customer Support",
                Address = "33 Le Loi, Da Nang",
                Phone = "0922334455"
            });

        }

        public static List<Customer> GetAll() => customerList;

        public static Customer? GetById(int id) =>
            customerList.FirstOrDefault(c => c.CustomerID == id);

        public static void Add(Customer customer)
        {
            customer.CustomerID = customerList.Any() ? customerList.Max(c => c.CustomerID) + 1 : 1;
            customerList.Add(customer);
        }

        public static void Update(Customer customer)
        {
            var existing = GetById(customer.CustomerID);
            if (existing != null)
            {
                existing.CompanyName = customer.CompanyName;
                existing.ContactName = customer.ContactName;
                existing.ContactTitle = customer.ContactTitle;
                existing.Address = customer.Address;
                existing.Phone = customer.Phone;
            }
        }

        public static void Delete(int id)
        {
            var customer = GetById(id);
            if (customer != null) customerList.Remove(customer);
        }

        public static List<Customer> Search(string keyword) =>
            customerList.Where(c => c.CompanyName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                    c.ContactName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                    c.Phone.Contains(keyword)).ToList();
    }
}
