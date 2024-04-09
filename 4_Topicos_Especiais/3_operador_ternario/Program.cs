using System.Globalization;

namespace _3_operador_ternario

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double discount = (price < 20.0) ? price * 0.1 : price * 0.05;

            Console.WriteLine($"discount: {discount}");
        }
    }
}