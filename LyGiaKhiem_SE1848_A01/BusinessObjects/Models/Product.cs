﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public override string ToString() => $"{ProductName} - {UnitPrice:C}";
    }
}
