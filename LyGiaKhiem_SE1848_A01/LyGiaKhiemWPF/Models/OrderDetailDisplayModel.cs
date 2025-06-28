using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyGiaKhiemWPF.Models
{
    public class OrderDetailDisplayModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = "";
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; } 
        public decimal Total => UnitPrice * Quantity * (1 - Discount);
    }
}
