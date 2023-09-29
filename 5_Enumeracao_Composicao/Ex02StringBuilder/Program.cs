using Ex02StringBuilder.Entities;

namespace Ex02StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this beautiful country",
                12
                );
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            p1.AddComment(c1);
            p1.AddComment(c2);

            Post p2 = new Post(
                DateTime.Parse("21/06/2018 23:55:14"),
                "Good night",
                "See you tomorrow",
                5
                );
            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the force be with you!");
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}