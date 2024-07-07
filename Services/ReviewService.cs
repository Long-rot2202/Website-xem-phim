// Services/ReviewService.cs
using MovieStreamingApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieStreamingApp.Services
{
    public class ReviewService
    {
        private List<Review> Reviews = new List<Review>();

        public List<Review> GetReviewsByMovieId(int movieId)
        {
            return Reviews.Where(r => r.MovieId == movieId).ToList();
        }

        public void AddReview(Review review)
        {
            review.Id = Reviews.Count > 0 ? Reviews.Max(r => r.Id) + 1 : 1;
            review.DatePosted = DateTime.Now;
            Reviews.Add(review);
        }
    }
}
