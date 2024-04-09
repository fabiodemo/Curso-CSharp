using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03Orders.Entities.Enums;

namespace Ex03Orders.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus orderStatus)
        {
            Moment = moment;
            OrderStatus = orderStatus;
        }
    }
}
