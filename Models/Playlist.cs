using System.ComponentModel.DataAnnotations;

namespace podcast_player_BE.Models
{
    public class Playlist
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string PodcastQuantity { get; set; }
        public string Image { get; set; }
        public string PodcastID { get; set; }
        public string OwnerID { get; set; }
    }
}
