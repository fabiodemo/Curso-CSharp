
namespace _6_timespan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // store the duration in the format of ticks
            //TimeSpan t1 = new TimeSpan(0, 1, 30);
            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks);

            //TimeSpan t2 = new TimeSpan();
            //TimeSpan t3 = new TimeSpan(90000000L);
            //TimeSpan t4 = new TimeSpan(2, 11, 21, 21);
            //TimeSpan t5 = new TimeSpan(2, 11, 21, 21, 212);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);

            //Console.WriteLine(TimeSpan.FromDays(1.5));
            //Console.WriteLine(TimeSpan.FromMilliseconds(1.5));
            //Console.WriteLine(TimeSpan.FromTicks(90000000L));

            // Operations with timespan
            TimeSpan t1 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t1);
            Console.WriteLine("Days: " + t1.Days);
            Console.WriteLine("Hours: " + t1.Hours);
            Console.WriteLine("Milliseconds: " + t1.Milliseconds);
            Console.WriteLine("Ticks: " + t1.Ticks);
            Console.WriteLine();

            Console.WriteLine("Days: " + t1.TotalDays);
            Console.WriteLine("Hours: " + t1.TotalHours);
            Console.WriteLine("Milliseconds: " + t1.TotalMilliseconds);

            TimeSpan t2 = new TimeSpan(1, 30, 10);
            TimeSpan t3 = new TimeSpan(0, 10, 5);

            Console.WriteLine(t2.Add(t3));
            Console.WriteLine(t2.Subtract(t3));
            Console.WriteLine(t3.Multiply(2.0));
            Console.WriteLine(t3.Divide(2.0));






        }
    }
}