using System;
using System.Globalization;

namespace Ex03
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quant;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quant;
        }

        public override string ToString()
        {
            // return Nome + ", $" + Preco;
            // return $"{Nome}, ${Preco}";
            return $"Dados do produto: {Nome}, $ {Preco}, {Quant} unidades, Total: $ {(ValorTotalEmEstoque()).ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void AdicionarProdutos(int quantity)
        {
            Quant += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quant -= quantity;
        }
    }
}
