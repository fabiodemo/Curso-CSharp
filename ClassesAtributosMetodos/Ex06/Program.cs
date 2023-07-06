//Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
//(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
//ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
//para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
//este problema.
using System;
using System.Globalization;
namespace Ex06;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();
        Console.Write("Nome do aluno: ");
        Console.ReadLine();
        Console.Write("Digite as três notas do aluno: ");
        for (int i = 0;i < 3;i++) 
        {
            aluno.Notas[i] = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
        }
        Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"{(aluno.Aprovado() ? "APROVADO" : "REPROVADO")}");
        if (!aluno.Aprovado()) Console.WriteLine($"FALTARAM {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
    }
}
