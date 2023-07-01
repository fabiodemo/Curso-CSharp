// Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
//hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
//decimais.
using System;
using System.Globalization;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora, para calcular o salário desse funcionário");
            int number = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            float valorHoras = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NUMBER = {number}\r\nSALARY = {(horas * valorHoras).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}