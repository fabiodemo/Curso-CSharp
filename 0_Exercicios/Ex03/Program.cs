//Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
//de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores separados por espaço (A B C D), para calcular a diferença do produto (A * B - C * D):");
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            int d = int.Parse(s[3]);
            Console.WriteLine($"DIFERENCA = {(a * b - c * d)}");
        }
    }
}