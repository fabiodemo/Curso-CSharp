using Enum.Entities;
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
            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // Doesnt work
            //OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered"); // Doesnt work as well
            OrderStatus os;
            System.Enum.TryParse("Delivered", out os);

            
            Console.WriteLine(order);
            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}