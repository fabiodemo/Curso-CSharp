﻿//Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
//uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
//que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
//para ser responsável pelos cálculos.
using System;
using System.Globalization;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double cot = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dólares você vai comprar? ");
            double quant = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            string valor = ConversorDeMoeda.Converter(cot, quant).ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais = {valor}");
        }
    }
}