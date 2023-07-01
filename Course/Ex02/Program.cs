//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
//casas decimais conforme exemplos.
//Fórmula da área: area = π.raio2
//Considere o valor de π = 3.1415
using System;
using System.Globalization;


namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do círculo:");
            double r = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture
                );
            double area = Math.PI * (r * r);
            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}