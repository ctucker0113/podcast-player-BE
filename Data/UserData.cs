using podcast_player_BE.Models;

namespace podcast_player_BE.Data
{
    public class UserData
    {
        public static List<User> Users = new List<User>
        {
            new User { Id = "1", FullName = "Taylor Seager", Uid = "user1" },
            new User { Id = "2", FullName = "Felicia Mings", Uid = "user2" },
            new User { Id = "3", FullName = "Cody Tucker", Uid = "user3" },
            new User { Id = "4", FullName = "Lucas Martin", Uid = "user4" },
        };
    }
}
