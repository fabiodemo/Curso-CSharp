using System;
using System.Globalization;
using Ex04Fixacao.Entities;
using Ex04Fixacao.Entities.Enums;
using Ex04Fixacao.Entities.Enums;

namespace Ex04Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client Data
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            // Order Data
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int itemsCount = int.Parse(Console.ReadLine());


            for (int i = 0; i < itemsCount; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);
            }

            // Output Order Summary
            //Console.WriteLine("\nORDER SUMMARY:");
            //Console.WriteLine($"Order moment: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            //Console.WriteLine($"Order status: {status}");
            //Console.WriteLine($"Client: {name} ({birthDate}) - {email}");

            //for (int i = 0; i < itemsCount; i++)
            //{
            //    Console.WriteLine($"Order items:");
            //    Console.WriteLine($"{productNames[i]}, ${productPrices[i]:0.00}, Quantity: {quantities[i]}, Subtotal: ${subtotals[i]:0.00}");
            //}

            //Console.WriteLine($"Total price: ${total:0.00}");
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);

        }
    }
}
