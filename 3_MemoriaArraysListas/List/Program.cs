using System.Collections.Generic;
namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //List<string> list2 = new List<string> { "Maria", "Alex", "Bob" };

            //Console.WriteLine(list);
            //Console.WriteLine(list2);

            list.Add("Ana Maria");
            list.Add("Alex");
            list.Add("Bobby");
            list.Add("Ana");
            list.Insert(1, "Onofre");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last Ocurrence of 'A': " + s1);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------");
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'A');
            Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            list.RemoveAt(1);
            Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            list.Add("Ana Maria");
            list.Add("Alex");
            list.Add("Bobby");
            list.Add("Ana");
            Console.WriteLine("-----------------\noriginal list");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveRange(2, 2);
            Console.WriteLine("-----------------\nremove 2 from range 2");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}