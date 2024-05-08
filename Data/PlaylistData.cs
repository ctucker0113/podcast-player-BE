using podcast_player_BE.Models;

namespace podcast_player_BE.Data
{
    public class PlaylistData
    {
        public static List<Playlist> Playlists = new List<Playlist>
        {
            new Playlist { Id = 1, Title = "Favorites", PodcastQuantity = 3, Image = "favorites.jpg", OwnerID = 1, Favorite = false },
            new Playlist { Id = 2, Title = "Top Picks", PodcastQuantity = 2, Image = "toppicks.jpg", OwnerID = 2, Favorite = false },
            new Playlist { Id = 3, Title = "Morning Drive", PodcastQuantity = 1, Image = "morningdrive.jpg", OwnerID = 3, Favorite = false },
            new Playlist { Id = 4, Title = "Inspiration", PodcastQuantity = 2, Image = "inspiration.jpg", OwnerID = 1, Favorite = false },
            new Playlist { Id = 5, Title = "Daily Commute", PodcastQuantity = 2, Image = "dailycommute.jpg", OwnerID = 2, Favorite = false }
        };
    }
}
