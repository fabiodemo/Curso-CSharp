// Fazer um programa para ler os valores da largura e altura de um retângulo. Em 
// seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
using System;
using System.Globalization;

namespace Ex04;

class Program
{
    static void Main(string[] args)
    {
        Retangulo ret = new Retangulo();
        
        Console.WriteLine("Entre a largura e altura do retângulo:");
        ret.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ret.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"ÁREA = {(ret.Area()).ToString("F2", CultureInfo.InvariantCulture)}");
 
        Console.WriteLine($"PERÍMETRO = {(ret.Perimetro()).ToString("F2", CultureInfo.InvariantCulture)}");
        
        Console.WriteLine($"DIAGONAL = {(ret.Diagonal()).ToString("F2", CultureInfo.InvariantCulture)}");
        ;
    }
}
