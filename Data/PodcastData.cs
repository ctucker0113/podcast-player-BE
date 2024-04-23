using podcast_player_BE.Models;

namespace podcast_player_BE.Data
{
    public class PodcastData
    {
        public static List<Podcast> Podcasts = new List<Podcast>
        {
            new Podcast { Id = "1", Name = "Podcast 1", Image = "image1.jpg", Author = "Author 1", Description = "Description 1", Length = 30 },
            new Podcast { Id = "2", Name = "Podcast 2", Image = "image2.jpg", Author = "Author 2", Description = "Description 2", Length = 45 },
            new Podcast { Id = "3", Name = "Podcast 3", Image = "image3.jpg", Author = "Author 3", Description = "Description 3", Length = 60 }
        };
    }
}
