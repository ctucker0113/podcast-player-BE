using podcast_player_BE.Models;

namespace podcast_player_BE.Data
{
    public class PodcastData
    {
        public static List<Podcast> Podcasts = new List<Podcast>
        {
            new Podcast { Id = 1, Name = "The Joe Rogan Experience", Image = "jre.jpg", Author = "Joe Rogan", Description = "Conversations with interesting people.", Length = 120, Favorite = false },
            new Podcast { Id = 2, Name = "TED Radio Hour", Image = "ted.jpg", Author = "TED", Description = "Exploring big ideas through powerful talks.", Length = 60, Favorite = false },
            new Podcast { Id = 3, Name = "Serial", Image = "serial.jpg", Author = "Sarah Koenig", Description = "Investigative journalism series.", Length = 45, Favorite = false },
            new Podcast { Id = 4, Name = "The Tim Ferriss Show", Image = "timferriss.jpg", Author = "Tim Ferriss", Description = "Interviews with top performers.", Length = 90, Favorite = false },
            new Podcast { Id = 5, Name = "Radiolab", Image = "radiolab.jpg", Author = "Jad Abumrad & Robert Krulwich", Description = "Science, philosophy, and storytelling.", Length = 75, Favorite = false },
            new Podcast { Id = 6, Name = "Stuff You Should Know", Image = "sysk.jpg", Author = "Josh Clark & Chuck Bryant", Description = "Explaining how stuff works.", Length = 50, Favorite = false },
            new Podcast { Id = 7, Name = "Freakonomics Radio", Image = "freakonomics.jpg", Author = "Stephen Dubner", Description = "Exploring the hidden side of everything.", Length = 55, Favorite = false },
            new Podcast { Id = 8, Name = "How I Built This", Image = "hibt.jpg", Author = "Guy Raz", Description = "Conversations with entrepreneurs.", Length = 70, Favorite = false },
            new Podcast { Id = 9, Name = "Planet Money", Image = "planetmoney.jpg", Author = "NPR", Description = "Understanding the economy.", Length = 40, Favorite = false },
            new Podcast { Id = 10, Name = "This American Life", Image = "tal.jpg", Author = "Ira Glass", Description = "Telling stories of everyday life.", Length = 80, Favorite = false }
        };
    }
}
