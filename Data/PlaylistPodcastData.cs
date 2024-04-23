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
            new PlaylistPodcast { Id = "4", PlaylistId = "2", PodcastId = "4" },
            new PlaylistPodcast { Id = "5", PlaylistId = "2", PodcastId = "5" },
            new PlaylistPodcast { Id = "6", PlaylistId = "3", PodcastId = "6" },
            new PlaylistPodcast { Id = "7", PlaylistId = "4", PodcastId = "7" },
            new PlaylistPodcast { Id = "8", PlaylistId = "4", PodcastId = "8" },
            new PlaylistPodcast { Id = "9", PlaylistId = "5", PodcastId = "9" },
            new PlaylistPodcast { Id = "10", PlaylistId = "5", PodcastId = "10" }
        };
    }
}
