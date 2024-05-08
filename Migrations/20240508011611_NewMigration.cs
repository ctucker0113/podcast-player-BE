using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace podcast_player_BE.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlaylistPodcasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlaylistId = table.Column<int>(type: "integer", nullable: false),
                    PodcastId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistPodcasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    PodcastQuantity = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    OwnerID = table.Column<int>(type: "integer", nullable: false),
                    Favorite = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Podcasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: false),
                    Favorite = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podcasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PlaylistPodcasts",
                columns: new[] { "Id", "PlaylistId", "PodcastId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 4 },
                    { 5, 2, 5 },
                    { 6, 3, 6 },
                    { 7, 4, 7 },
                    { 8, 4, 8 },
                    { 9, 5, 9 },
                    { 10, 5, 10 }
                });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "Favorite", "Image", "OwnerID", "PodcastQuantity", "Title" },
                values: new object[,]
                {
                    { 1, false, "favorites.jpg", 1, 3, "Favorites" },
                    { 2, false, "toppicks.jpg", 2, 2, "Top Picks" },
                    { 3, false, "morningdrive.jpg", 3, 1, "Morning Drive" },
                    { 4, false, "inspiration.jpg", 1, 2, "Inspiration" },
                    { 5, false, "dailycommute.jpg", 2, 2, "Daily Commute" }
                });

            migrationBuilder.InsertData(
                table: "Podcasts",
                columns: new[] { "Id", "Author", "Description", "Favorite", "Image", "Length", "Name" },
                values: new object[,]
                {
                    { 1, "Joe Rogan", "Conversations with interesting people.", false, "jre.jpg", 120, "The Joe Rogan Experience" },
                    { 2, "TED", "Exploring big ideas through powerful talks.", false, "ted.jpg", 60, "TED Radio Hour" },
                    { 3, "Sarah Koenig", "Investigative journalism series.", false, "serial.jpg", 45, "Serial" },
                    { 4, "Tim Ferriss", "Interviews with top performers.", false, "timferriss.jpg", 90, "The Tim Ferriss Show" },
                    { 5, "Jad Abumrad & Robert Krulwich", "Science, philosophy, and storytelling.", false, "radiolab.jpg", 75, "Radiolab" },
                    { 6, "Josh Clark & Chuck Bryant", "Explaining how stuff works.", false, "sysk.jpg", 50, "Stuff You Should Know" },
                    { 7, "Stephen Dubner", "Exploring the hidden side of everything.", false, "freakonomics.jpg", 55, "Freakonomics Radio" },
                    { 8, "Guy Raz", "Conversations with entrepreneurs.", false, "hibt.jpg", 70, "How I Built This" },
                    { 9, "NPR", "Understanding the economy.", false, "planetmoney.jpg", 40, "Planet Money" },
                    { 10, "Ira Glass", "Telling stories of everyday life.", false, "tal.jpg", 80, "This American Life" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "Uid" },
                values: new object[,]
                {
                    { 1, "Taylor Seager", "user1" },
                    { 2, "Felicia Mings", "user2" },
                    { 3, "Cody Tucker", "user3" },
                    { 4, "Lucas Martin", "user4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistPodcasts");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Podcasts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
