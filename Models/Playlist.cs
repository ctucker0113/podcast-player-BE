using System.ComponentModel.DataAnnotations;

namespace podcast_player_BE.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PodcastQuantity { get; set; }
        public string Image { get; set; }
        public int OwnerID { get; set; }
    }
}
