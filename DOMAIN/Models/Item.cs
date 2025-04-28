﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int LowStockThreshold { get; set; } // For Stock Alert
    }

}
