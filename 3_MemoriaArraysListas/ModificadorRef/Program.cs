namespace ModificadorRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ref e out são code smells
            int a = 10;
            Calculator.Triple(ref a); // ref exige que a variável seja iniciada
            Console.WriteLine(a);

            int triple;
            Calculator.TripleNew(a, out triple);
            Console.WriteLine(triple);
        }
    }
}