//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
//código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
using System.Globalization;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores: código de uma peça 1, o número de peças 1 e o valor unitário de cada peça 1");
            string[] pecaUm = Console.ReadLine().Split(' ');
            Console.WriteLine("Digite os valores: código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2");
            string[] pecaDois = Console.ReadLine().Split(' ');
            
            int pecaUmCod = int.Parse(pecaUm[0]);
            int pecaUmUnid = int.Parse(pecaUm[1]);
            float pecaUmValor = float.Parse(pecaUm[2], CultureInfo.InvariantCulture);
            int pecaDoisCod = int.Parse(pecaDois[0]);
            int pecaDoisUnid = int.Parse(pecaDois[1]);
            float pecaDoisValor = float.Parse(pecaDois[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a pagar: R$ {((pecaUmUnid * pecaUmValor) + (pecaDoisUnid * pecaDoisValor)).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}