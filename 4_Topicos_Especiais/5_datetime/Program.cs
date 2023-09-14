using System.Globalization;

namespace _5_datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = DateTime.Now;
            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            //DateTime d2 = new DateTime(2018, 11, 25);
            //DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            //DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            //Console.WriteLine(DateTime.Today);
            //Console.WriteLine(DateTime.UtcNow);

            //Console.WriteLine(DateTime.Parse("2000-08-15"));
            //Console.WriteLine(DateTime.Parse("2000-08-15 13:05:58"));
            //Console.WriteLine(DateTime.Parse("2000/08/08"));

            //DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //Console.WriteLine(d5);
            //DateTime d6 = DateTime.ParseExact("2000/08/15 13:05:58", "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
            //Console.WriteLine(d6);


            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 276);

            //Console.WriteLine(d);
            //Console.WriteLine("Date:" + d.Date);
            //Console.WriteLine("Day of the week:" + d.DayOfWeek);
            //Console.WriteLine("Day of the week:" + d.DayOfYear);
            //Console.WriteLine("Hour:" + d.Hour);
            //Console.WriteLine("Kind:" + d.Kind);
            //Console.WriteLine("TimeOfDay:" + d.TimeOfDay);
            //Console.WriteLine();

            //Console.WriteLine(d.ToLongDateString());
            //Console.WriteLine(d.ToLongTimeString());
            //Console.WriteLine(d.ToShortDateString());
            //Console.WriteLine(d.ToBinary());


            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            // Operations with datetime
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 276);

            DateTime d2 = d.AddHours(7);

            Console.WriteLine(d);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2000, 10, 10);
            DateTime d4 = new DateTime(2000, 10, 18);
            Console.WriteLine(d4.Subtract(d3));

            DateTime d5 = new DateTime(2000, 10, 10);
            DateTime d6 = new DateTime(2008, 10, 10);
            Console.WriteLine(d6.Subtract(d4));



        }
    }
}