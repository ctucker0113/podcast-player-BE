using podcast_player_BE.Models;

namespace podcast_player_BE.Data
{
    public class UserData
    {
        public static List<User> Users = new List<User>
        {
            new User { Id = "1", FullName = "John Doe", Uid = "user1" },
            new User { Id = "2", FullName = "Jane Smith", Uid = "user2" },
            new User { Id = "3", FullName = "Alice Johnson", Uid = "user3" }
        };
    }
}
