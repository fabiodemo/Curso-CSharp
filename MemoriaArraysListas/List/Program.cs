using System.Collections.Generic;
namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Maria", "Alex", "Bob" };

            Console.WriteLine(list);
            Console.WriteLine(list2);
        }
    }
}