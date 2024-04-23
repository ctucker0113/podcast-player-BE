using podcast_player_BE.Models;

namespace podcast_player_BE.Data
{
    public class PlaylistData
    {
        public static List<Playlist> Playlists = new List<Playlist>
        {
            new Playlist { Id = "1", Title = "Favorites", PodcastQuantity = "3", Image = "favorites.jpg", PodcastID = "1,2,3", OwnerID = "1" },
            new Playlist { Id = "2", Title = "Top Picks", PodcastQuantity = "2", Image = "toppicks.jpg", PodcastID = "4,5", OwnerID = "2" },
            new Playlist { Id = "3", Title = "Morning Drive", PodcastQuantity = "1", Image = "morningdrive.jpg", PodcastID = "6", OwnerID = "3" },
            new Playlist { Id = "4", Title = "Inspiration", PodcastQuantity = "2", Image = "inspiration.jpg", PodcastID = "7,8", OwnerID = "1" },
            new Playlist { Id = "5", Title = "Daily Commute", PodcastQuantity = "2", Image = "dailycommute.jpg", PodcastID = "9,10", OwnerID = "2" }
        };
    }
}
