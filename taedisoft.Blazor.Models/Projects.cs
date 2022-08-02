﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taedisoft.Blazor.DataModels
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string? Brand { get; set; }
    }
}