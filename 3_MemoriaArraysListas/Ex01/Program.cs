namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] quartos = new Aluguel[10];

            Console.Write("How Many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                int room = 0;
                do
                {
                    Console.Write("Room: ");
                    room = int.Parse(Console.ReadLine());
                    if (quartos[room] != null)
                    {
                        Console.WriteLine("Room already occupied! Select another room ");
                    }
                } while (quartos[room] != null);
                Console.WriteLine(room);
                quartos[room] = new Aluguel { Name = name, Email = email };
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i}: {quartos[i].ToString()}");
                }
            }

        }
    }
}