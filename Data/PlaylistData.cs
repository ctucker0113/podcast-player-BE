using podcast_player_BE.Models;

namespace podcast_player_BE.Data
{
    public class PlaylistData
    {
        public static List<Playlist> Playlists = new List<Playlist>
        {
            new Playlist { Id = "1", Title = "Playlist 1", PodcastQuantity = "3", Image = "playlist1.jpg", PodcastID = "1,2,3", OwnerID = "1" },
            new Playlist { Id = "2", Title = "Playlist 2", PodcastQuantity = "2", Image = "playlist2.jpg", PodcastID = "2,3", OwnerID = "2" },
            new Playlist { Id = "3", Title = "Playlist 3", PodcastQuantity = "1", Image = "playlist3.jpg", PodcastID = "3", OwnerID = "3" }
        };
    }
}
