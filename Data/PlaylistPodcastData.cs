using podcast_player_BE.Models;

namespace podcast_player_BE.Data
{
    public class PlaylistPodcastData
    {
        public static List<PlaylistPodcast> PlaylistPodcasts = new List<PlaylistPodcast>
        {
            new PlaylistPodcast { Id = "1", PlaylistId = "1", PodcastId = "1" },
            new PlaylistPodcast { Id = "2", PlaylistId = "1", PodcastId = "2" },
            new PlaylistPodcast { Id = "3", PlaylistId = "1", PodcastId = "3" },
            new PlaylistPodcast { Id = "4", PlaylistId = "2", PodcastId = "2" },
            new PlaylistPodcast { Id = "5", PlaylistId = "2", PodcastId = "3" },
            new PlaylistPodcast { Id = "6", PlaylistId = "3", PodcastId = "3" }
        };
    }
}
