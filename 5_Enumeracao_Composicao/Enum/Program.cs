﻿using Enum.Entities;
using Enum.Entities.Enums;
using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };


            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            
            Console.WriteLine(order);
            Console.WriteLine(txt);
        }
    }
}