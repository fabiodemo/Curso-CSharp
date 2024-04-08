namespace Ex04Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client Data
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            string birthDate = Console.ReadLine();

            // Order Data
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string status = Console.ReadLine();

            Console.Write("How many items to this order? ");
            int itemsCount = int.Parse(Console.ReadLine());

            // Assuming we only handle up to 2 items for simplicity
            string[] productNames = new string[itemsCount];
            decimal[] productPrices = new decimal[itemsCount];
            int[] quantities = new int[itemsCount];
            decimal[] subtotals = new decimal[itemsCount];
            decimal total = 0;

            for (int i = 0; i < itemsCount; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                productNames[i] = Console.ReadLine();

                Console.Write("Product price: ");
                productPrices[i] = decimal.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                quantities[i] = int.Parse(Console.ReadLine());

                // Calculate subtotal
                subtotals[i] = productPrices[i] * quantities[i];

                // Add to total
                total += subtotals[i];
            }

            // Output Order Summary
            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine($"Order moment: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine($"Order status: {status}");
            Console.WriteLine($"Client: {name} ({birthDate}) - {email}");

            for (int i = 0; i < itemsCount; i++)
            {
                Console.WriteLine($"Order items:");
                Console.WriteLine($"{productNames[i]}, ${productPrices[i]:0.00}, Quantity: {quantities[i]}, Subtotal: ${subtotals[i]:0.00}");
            }

            Console.WriteLine($"Total price: ${total:0.00}");
        }
    }
}
