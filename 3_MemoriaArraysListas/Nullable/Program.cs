using System.Drawing;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x = null; // Non-nullable
            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Console.WriteLine(x.Value); //  Nullable object must have a value.
            if (x.HasValue) Console.WriteLine(x.Value);
            else Console.WriteLine("X é nulo!");

            if (y.HasValue) Console.WriteLine(y.Value);
            else Console.WriteLine("Y é nulo!");

            // Coalescência nula
            // Se o primeiro valor for nulo, pega o segundo valor
            //double? a = null;

            double? a = null;
            double? b = 10;

            double c = x ?? 5;
            double d = y ?? 5;
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}