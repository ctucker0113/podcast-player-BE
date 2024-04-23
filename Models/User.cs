using System.ComponentModel.DataAnnotations;

namespace podcast_player_BE.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Uid { get; set; }
    }
}
