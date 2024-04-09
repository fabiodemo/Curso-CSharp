//Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
//mostre: 
//a) a área do triângulo retângulo que tem A por base e C por altura. 
//b) a área do círculo de raio C. (pi = 3.14159) 
//c) a área do trapézio que tem A e B por bases e C por altura. 
//d) a área do quadrado que tem lado B. 
//e) a área do retângulo que tem lados A e B.

using System.Globalization;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira três valores flutuantes separados por espaço: A, B e C");
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"TRIANGULO : {((a * c)/2).ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO : {(3.14159 * (c * c)).ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO : {((a + b) / 2.0 * c).ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO : {(b * b).ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO : {(a * b).ToString("F4", CultureInfo.InvariantCulture)}");

        }
    }
}