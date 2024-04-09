using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Orders.Entities
{
    internal class OrderItem
    {
        public int Quality { get; set; }
        public double Price { get; set; }


        public OrderItem() { }

        public OrderItem(int quality, double price)
        {
            Quality = quality;
            Price = price;
        }

        public double SubTotal()
        {
            return 0.0;
        }
    }

}
