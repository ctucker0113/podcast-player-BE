using System.ComponentModel.DataAnnotations;

namespace podcast_player_BE.Models
{
    public class PlaylistPodcast
    {
        public int Id { get; set; }
        public int PlaylistId { get; set; }
        public int PodcastId { get; set; }
    }
}
