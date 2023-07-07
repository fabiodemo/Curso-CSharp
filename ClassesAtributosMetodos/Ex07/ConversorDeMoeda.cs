//Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
//uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
//que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
//para ser responsável pelos cálculos.

namespace Ex07
{
    class ConversorDeMoeda
    {
        public static double Iof = 6;

        public static double Converter(double cot, double quant)
        {
            double convertido = (quant * cot);
            return (convertido + (convertido * Iof/100));
        }
    }
}