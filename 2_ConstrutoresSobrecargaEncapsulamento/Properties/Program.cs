using System.Globalization;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Properties
            Produto p = new Produto("tv", 500.0, 10);

            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            p.Nome = "T";
            Console.WriteLine(p.Nome);
            //p.Preco = 20.00; // Erro, pois só teremos o get nesse caso
        }
    }
}