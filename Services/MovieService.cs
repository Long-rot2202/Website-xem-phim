using MovieStreamingApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieStreamingApp.Services
{
    public class MovieService
    {
        private List<Movie> Movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Avengers 1", Description = "The Avengers là bộ phim giả tưởng kể về một nhóm siêu anh hùng với những khả năng đặc biệt, họ bao gồm: Người Sắt, Thor, Đội trưởng Mỹ, và Người Khổng Lồ Xanh Hulk cùng tham gia với tổ chức bảo vệ thế giới SHIELD. Mục đích của SHIELD là nhằm bảo vệ Trái Đất khỏi âm mưu hủy hoại của những thế lực xấu từ ngoài địa cầu mà kẻ cầm đầu là Loki.", ImageUrl = "https://i.imgur.com/p7B7FuT.jpeg", VideoUrl = "/videos/Marvel s The Avengers- Trailer (OFFICIAL).mp4" },
            new Movie { Id = 2, Title = "Cửu Long thành trại: Vây thành", Description = "Lấy bối cảnh những năm 1980, chàng thanh niên gặp rắc rối Chan Lok-kwun vô tình đi vào Thành phố có tường bao quanh, phát hiện ra trật tự giữa sự hỗn loạn của nó và học được những bài học quan trọng trong cuộc sống trên đường đi. Tại Walled City, anh trở thành bạn thân của Shin, Master thứ mười hai và AV. Dưới sự lãnh đạo của Cyclone, họ chống lại sự xâm lược của kẻ phản diện Mr. Big trong hàng loạt trận chiến khốc liệt. Cùng nhau, họ thề sẽ bảo vệ nơi trú ẩn an toàn là Thành phố có tường bao quanh Cửu Long.", ImageUrl = "https://i.imgur.com/GK80wrR.jpeg", VideoUrl = "/videos/CỬU LONG THÀNH TRẠI_ VÂY THÀNH _ OFFICIAL TRAILER _ DKKC_ 14.06.2024.mp4" }
        };

        public List<Movie> GetMovies() => Movies;

        public Movie GetMovieById(int id) => Movies.FirstOrDefault(m => m.Id == id);

        public List<Movie> SearchMovies(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return Movies;
            }
            return Movies.Where(m => m.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
