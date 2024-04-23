using System.ComponentModel.DataAnnotations;

namespace podcast_player_BE.Models
{
    public class PlaylistPodcast
    {
        public string Id { get; set; }
        public string PlaylistId { get; set; }
        public string PodcastId { get; set; }
    }
}
