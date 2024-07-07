// Models/Review.cs
namespace MovieStreamingApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Username { get; set; }
        public int Rating { get; set; } // Rating từ 1 đến 5
        public string Comment { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
