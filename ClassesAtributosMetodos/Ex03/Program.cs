using System.Globalization;

namespace Ex03;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();

        Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        produto.Quant = int.Parse(Console.ReadLine());
        Console.WriteLine(produto);
        // produto.ValorTotalEmEstoque();

        Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
        produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Dados do produto: {produto.Nome}, $ {produto.Preco}, {produto.Quant} unidades, Total: $ {(produto.ValorTotalEmEstoque()).ToString("F2", CultureInfo.InvariantCulture)}");

        Console.Write("Digite o número de produtos a serem removidos do estoque: ");
        produto.RemoverProdutos(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Dados do produto: {produto.Nome}, $ {produto.Preco}, {produto.Quant} unidades, Total: $ {(produto.ValorTotalEmEstoque()).ToString("F2", CultureInfo.InvariantCulture)}");

    }
}
