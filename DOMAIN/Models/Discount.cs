﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Percentage { get; set; }
        public bool IsActive { get; set; }
    }

}
