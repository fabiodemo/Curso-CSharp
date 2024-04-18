﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product () { }

        public Product (string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string PriceTag()
        {
            return "sus";
        }
    }
}
