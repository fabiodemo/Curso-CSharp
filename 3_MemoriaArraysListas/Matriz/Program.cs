namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double[,] mat = new double[2,3];

            //Console.WriteLine($"{mat}");

            //Console.WriteLine(mat.Length);

            //Console.WriteLine(mat.Rank);

            //Console.WriteLine(mat.GetLength(0));
            //Console.WriteLine(mat.GetLength(1));

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    //mat[i, j] = int.Parse(Console.ReadLine());
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            // Diagonal principal
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            // Contar negativos
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}