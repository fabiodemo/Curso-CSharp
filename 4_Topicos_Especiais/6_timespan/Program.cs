
namespace _6_timespan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // store the duration in the format of ticks
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(90000000L);
            TimeSpan t4 = new TimeSpan(2, 11, 21, 21);
            TimeSpan t5 = new TimeSpan(2, 11, 21, 21, 212);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine(TimeSpan.FromDays(1.5));
            Console.WriteLine(TimeSpan.FromMilliseconds(1.5));
            Console.WriteLine(TimeSpan.FromTicks(90000000L));


        }
    }
}