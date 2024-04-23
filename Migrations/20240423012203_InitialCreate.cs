using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace podcast_player_BE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlaylistPodcasts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    PlaylistId = table.Column<string>(type: "text", nullable: false),
                    PodcastId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistPodcasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    PodcastQuantity = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    PodcastID = table.Column<string>(type: "text", nullable: false),
                    OwnerID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Podcasts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podcasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
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
                    { "1", "1", "1" },
                    { "2", "1", "2" },
                    { "3", "1", "3" },
                    { "4", "2", "2" },
                    { "5", "2", "3" },
                    { "6", "3", "3" }
                });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "Image", "OwnerID", "PodcastID", "PodcastQuantity", "Title" },
                values: new object[,]
                {
                    { "1", "playlist1.jpg", "1", "1,2,3", "3", "Playlist 1" },
                    { "2", "playlist2.jpg", "2", "2,3", "2", "Playlist 2" },
                    { "3", "playlist3.jpg", "3", "3", "1", "Playlist 3" }
                });

            migrationBuilder.InsertData(
                table: "Podcasts",
                columns: new[] { "Id", "Author", "Description", "Image", "Length", "Name" },
                values: new object[,]
                {
                    { "1", "Author 1", "Description 1", "image1.jpg", 30, "Podcast 1" },
                    { "2", "Author 2", "Description 2", "image2.jpg", 45, "Podcast 2" },
                    { "3", "Author 3", "Description 3", "image3.jpg", 60, "Podcast 3" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "Uid" },
                values: new object[,]
                {
                    { "1", "John Doe", "user1" },
                    { "2", "Jane Smith", "user2" },
                    { "3", "Alice Johnson", "user3" }
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
