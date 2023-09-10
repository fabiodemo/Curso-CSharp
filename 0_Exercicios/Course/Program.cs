using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n1 = int.MinValue;
            //int n2 = int.MaxValue;
            //sbyte n3 = sbyte.MinValue;
            //decimal n4 = decimal.MinValue;

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);

            // -----------------------------------------------------

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //string[] s = Console.ReadLine().Split(' ');
            //string a = s[0];
            //string b = s[1];
            //string c = s[2];

            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            // -----------------------------------------------------
            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] s = Console.ReadLine().Split(' ');
            //string nome = s[0];
            //char sexo = char.Parse(s[1]);
            //int idade = int.Parse(s[2]);
            //double altura = double.Parse(s[3], CultureInfo.InvariantCulture);

            //Console.WriteLine("você digitou: " + n1);
            //Console.WriteLine("você digitou: " + ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            // Exercicio: fazer um programa para executar a interação com o usuário, lendo valores e depois mostrando em telas
            Console.WriteLine("Digite seu nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int bedrooms = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o preço de um produto");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] s = Console.ReadLine().Split(' ');
            string lastName = s[0];
            int age = int.Parse(s[1]);
            double height = double.Parse(s[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}