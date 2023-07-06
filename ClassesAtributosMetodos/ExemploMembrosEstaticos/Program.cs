using System;
using System.Globalization;

namespace ExemploMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine($"Circunferencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}");


            double volume = Calculadora.Volume(raio);
            Console.WriteLine($"Circunferencia: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}