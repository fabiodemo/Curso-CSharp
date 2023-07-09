using System.Globalization;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto p = new Produto("TV", 500.0, 10);
            //Console.WriteLine(p);

            Produto p = new Produto
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };

            // Podemos alterar a quantidade conforme quisermos
            p.Quantidade = -10;

        }
    }
}