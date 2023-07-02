namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaUm = new Pessoa();
            Pessoa pessoaDois = new Pessoa();

            Console.Write("Dados da primeira pessoa:\r\nNome: ");
            pessoaUm.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaUm.idade = int.Parse(Console.ReadLine());
            Console.Write("Dados da segunda pessoa:\r\nNome: ");
            pessoaDois.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaDois.idade = int.Parse(Console.ReadLine());

            if (pessoaUm.idade > pessoaDois.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoaUm.nome}");
            }
            else if (pessoaDois.idade > pessoaUm.idade) 
            {
                Console.WriteLine($"Pessoa mais velha: {pessoaDois.nome}");
            }
            else
            {
                Console.WriteLine("As duas pessoas tem a mesma idade!");
            }
        }
    }
}