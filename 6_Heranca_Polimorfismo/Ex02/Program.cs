/*
 Fazer um programa para ler os dados de N
produtos (N fornecido pelo usuário). Ao final,
mostrar a etiqueta de preço de cada produto na
mesma ordem em que foram digitados.

Todo produto possui nome e preço. Produtos
importados possuem uma taxa de alfândega, e
produtos usados possuem data de fabricação.
Estes dados específicos devem ser
acrescentados na etiqueta de preço conforme
exemplo (próxima página). 

Para produtos importados, a taxa e alfândega deve ser
acrescentada ao preço final do produto.
Favor implementar o programa conforme
projeto ao lado.
 */
using Ex02.Entities;
using System.Globalization;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many products?");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i} Data:");
                Console.WriteLine("Common, used or imported (c/u/i)?");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if(type == 'i') {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customFee));
                }
                else
                {
                    products.Add(new Product(name, price));
                }

            }
            
            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS:");

        }
    }
}
