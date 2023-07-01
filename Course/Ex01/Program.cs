using System.Runtime.ConstrainedExecution;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            //mensagem explicativa, conforme exemplos
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"SOMA = {a+b}");
        }
    }
}