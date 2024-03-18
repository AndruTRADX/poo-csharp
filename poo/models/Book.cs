using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.models
{
    internal class Book
    {
        private static int id = 0;
        private string title;
        private string author;
        private string releaseDate;
        private readonly List<Review> reviews;

        public Book(string title, string author, string releaseDate)
        {
            id++;
            this.title = title;
            this.author = author;
            this.releaseDate = releaseDate;
            this.reviews = new List<Review>();
        }

        // Getter & Setter
        public static int Id() { return id; }
        public string Title
        { get { return title; } set { title = value.Trim(); } }
        public string Author
        { get { return author; } set { author = value.Trim(); } }
        public string ReleaseDate
        { get { return releaseDate; } set { releaseDate = value.Trim(); } }
        public List<Review> Reviews 
        { get {  return reviews; } }

        // Métodos
        public string GetAllReviews()
        {
            StringBuilder allReviews = new ();
            foreach (Review review in reviews)
            {
                allReviews.AppendLine(review.ToString());
            }
            return allReviews.ToString();
        }
        public void AddReview(Review review)
        {
            reviews.Add(review);
        }
    }
}
