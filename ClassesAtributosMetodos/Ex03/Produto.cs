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
