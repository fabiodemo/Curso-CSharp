using System.Globalization;

namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vet[i];
            }

            double avg = sum / n;

            Console.WriteLine($"AVERAGE HEIGHT {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}