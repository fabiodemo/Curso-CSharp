using System.Globalization;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv", 500.0, 10);
            //Console.WriteLine(p);

            //Produto p = new Produto
            //{
            //    _nome = "TV",
            //    _preco = 500.00,
            //    _quantidade = 20
            //};

            // Podemos alterar a quantidade conforme quisermos, isso não é ideal
            //p.Quantidade = -10;
            // Só devemos alterar o valor da quantidade através dos métodos da classe

            // Com o encapsulamento, torna-se impossível até acessar e imprimir
            //Console.WriteLine(p._nome);

            Console.WriteLine(p.GetNome());

            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());

            // Assegurar manter um estado consistente no objeto, não permitindo mudar o nome para somente um caracter
            p.SetNome("T");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

        }
    }
}