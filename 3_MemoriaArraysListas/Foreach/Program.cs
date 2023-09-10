namespace Foreach;

class Program
{
    static void Main(string[] args)
    {
        string[] vect = new string[] { "Maria", "Alex", "Roberto" };
        for (int i = 0; i < vect.Length; i++) {
            Console.WriteLine($"{vect[i]}");
        }

        Console.WriteLine("---------------");
        foreach (string s in vect)
        {
            Console.WriteLine(s);
        }
    }
}
