using poo.models;

namespace poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Books application!");

            Book book1 = new("The Great Gatsby", "F. Scott Fitzgerald", "1925-04-10");
            book1.AddReview(new("Usuario", Rate.FIVE, "Texto de la reseña"));
            book1.AddReview(new("Usuario", Rate.FIVE, "Texto de la reseña"));
            book1.AddReview(new("Usuario", Rate.FIVE, "Texto de la reseña"));

            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Author);
            Console.WriteLine(book1.GetAllReviews());
        }

    }
}
