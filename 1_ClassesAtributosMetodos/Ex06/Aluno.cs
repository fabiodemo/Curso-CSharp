//Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
//(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
//ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
//para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
//este problema.
using System;
using System.Globalization;

namespace Ex06
{
    class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];


        public double NotaFinal()
        {
            double soma = 0;
            foreach (double nota in Notas)
            {
                soma += nota;
            }
            return soma;
        }

        //public string Resultado()
        //{
        //    if (NotaFinal >= 60.0) {
        //        return "APROVADO";
        //    }
        //    return $"REPROVADO\r\nFALTARAM {(60 - NotaFinal).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
        //}

        public bool Aprovado()
        {
            return NotaFinal() >= 60;
        }

        public double NotaRestante()
        {
            double notaFinal = NotaFinal();
            return notaFinal >= 60.0 ? 0.0 : 60.0 - NotaFinal();
        }

    }
}