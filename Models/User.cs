using System.ComponentModel.DataAnnotations;

namespace podcast_player_BE.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Uid { get; set; }
    }
}
