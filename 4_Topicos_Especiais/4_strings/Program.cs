namespace _4_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";
            
            Console.WriteLine(original);
            Console.WriteLine(original.ToUpper());
            Console.WriteLine(original.ToLower());
            Console.WriteLine(original);

            Console.WriteLine(original.IndexOf("bc"));
            Console.WriteLine(original.IndexOf("FG"));
            Console.WriteLine(original.LastIndexOf("bc"));

            Console.WriteLine(original.Substring(3));
            Console.WriteLine(original.Substring(3, 5));

            Console.WriteLine(original.Replace('a', 'x'));
            
            Console.WriteLine(string.IsNullOrEmpty(original));
            Console.WriteLine(string.IsNullOrWhiteSpace(original));
            Console.WriteLine(string.IsNullOrWhiteSpace(" "));



        }
    }
}