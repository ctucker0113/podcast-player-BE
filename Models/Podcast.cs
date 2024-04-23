using System.ComponentModel.DataAnnotations;

namespace podcast_player_BE.Models
{
    public class Podcast
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }
    }
}
