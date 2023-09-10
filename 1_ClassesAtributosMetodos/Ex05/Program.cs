//Fazer um programa para ler os dados de um funcionário (nome,
//salário bruto e imposto). Em seguida, mostrar os dados do
//funcionário (nome e salário líquido). Em seguida, aumentar o salário
//do funcionário com base em uma porcentagem dada (somente o
//salário bruto é afetado pela porcentagem) e mostrar novamente os
//dados do funcionário. Use a classe projetada abaixo.
using System;
using System.Globalization;

namespace Ex05;

class Program
{
    static void Main(string[] args)
    {
        Funcionario func = new Funcionario();

        Console.Write("Nome: ");
        func.Nome = Console.ReadLine();
        Console.Write("Salário Bruto: ");
        func.SalarioBruto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        func.Imposto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Funcionário: {func}");

        Console.Write("Digite a porcentagem para aumentar o salário: ");
        func.AumentarSalario(Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine($"Dados atualizados: {func}");

    }
}
