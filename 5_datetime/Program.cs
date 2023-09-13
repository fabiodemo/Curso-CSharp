using System.Globalization;

namespace _5_datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);

            Console.WriteLine(DateTime.Parse("2000-08-15"));
            Console.WriteLine(DateTime.Parse("2000-08-15 13:05:58"));
            Console.WriteLine(DateTime.Parse("2000/08/08"));

            DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d5);
            DateTime d6 = DateTime.ParseExact("2000/08/15 13:05:58", "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d6);


        }
    }
}