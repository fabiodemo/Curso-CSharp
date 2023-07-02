//Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário 
//médio dos funcionários
using System.Globalization;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario primeiroFunc = new Funcionario();
            Funcionario segundoFunc = new Funcionario();
            double salarioMedio = 0;
            
            Console.Write("Dados do primeiro funcionario:\r\nNome:");
            primeiroFunc.nome = Console.ReadLine();
            Console.Write("Salário: ");
            primeiroFunc.salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Dados do segundo funcionario:\r\nNome:");
            segundoFunc.nome = Console.ReadLine();
            Console.Write("Salário: ");
            segundoFunc.salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMedio = ((primeiroFunc.salario + segundoFunc.salario) / 2);
            Console.WriteLine($"Salário médio: {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}