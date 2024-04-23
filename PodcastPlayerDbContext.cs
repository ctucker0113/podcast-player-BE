using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.Hosting;
using podcast_player_BE.Data;
using podcast_player_BE.Models;

public class PodcastPlayerDbContext : DbContext
{

    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<PlaylistPodcast> PlaylistPodcasts { get; set; }
    public DbSet<Podcast> Podcasts { get; set; }
    public DbSet<User> Users { get; set; }

    public PodcastPlayerDbContext(DbContextOptions<PodcastPlayerDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Playlist>().HasData(PlaylistData.Playlists);
        modelBuilder.Entity<PlaylistPodcast>().HasData(PlaylistPodcastData.PlaylistPodcasts);
        modelBuilder.Entity<Podcast>().HasData(PodcastData.Podcasts);
        modelBuilder.Entity<User>().HasData(UserData.Users);
    }
}