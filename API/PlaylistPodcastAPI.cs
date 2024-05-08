using podcast_player_BE.API;
using podcast_player_BE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace podcast_player_BE.API
{
    public static class PlaylistPodcastAPI
    {
        public static void Map(WebApplication app)
        {
            // Get All Playlist-Podcast Relationships
            app.MapGet("/api/getAllPlaylistpodcastRelationships", (PodcastPlayerDbContext db) =>
            {
                return db.PlaylistPodcasts.ToList();
            });

            // Get All Podcasts For Single Playlist
            app.MapGet("/api/getAllPodcastsForSinglePlaylist/{playlistId}", (PodcastPlayerDbContext db, int playlistId) =>
            {
                var playlistPodcasts = db.PlaylistPodcasts
                                         .Where(pp => pp.PlaylistId == playlistId)
                                         .Join(db.Podcasts,
                                               pp => pp.PodcastId,
                                               p => p.Id,
                                               (pp, p) => new
                                               {
                                                   PlaylistPodcast = pp,
                                                   Podcast = p
                                               })
                                         .ToList();

                if (playlistPodcasts == null || playlistPodcasts.Count == 0)
                {
                    return Results.NotFound("No Podcasts Found For This Playlist.");
                }

                // Prepare the response data
                var playlistDetails = db.Playlists
                                    .Where(p => p.Id == playlistId)
                                    .FirstOrDefault();

                var response = new
                {
                    PlaylistDetails = playlistDetails,
                    Podcasts = playlistPodcasts.Select(pp => new
                    {
                        id = pp.Podcast.Id,
                        name = pp.Podcast.Name,
                        image = pp.Podcast.Image,
                        author = pp.Podcast.Author,
                        length = pp.Podcast.Length,
                        description = pp.Podcast.Description,
                        favorite = pp.Podcast.Favorite
                    })
                };

                return Results.Ok(response);
            });

            // Add Podcast to Playlist
            app.MapPost("/api/addPodcastToPlaylist/{playlistId}/{podcastId}", (PodcastPlayerDbContext db, int playlistId, int podcastId) =>
            {
                var playlist = db.Playlists.Find(playlistId);
                var podcast = db.Podcasts.Find(podcastId);

                if (playlist == null || podcast == null)
                {
                    return Results.NotFound("Playlist or Podcast not found.");
                }

                // Check if the playlist already contains the podcast
                var existingPlaylistPodcast = db.PlaylistPodcasts.FirstOrDefault(pp => pp.PlaylistId == playlistId && pp.PodcastId == podcastId);

                if (existingPlaylistPodcast != null)
                {
                    return Results.BadRequest("Podcast already exists in the playlist.");
                }

                // Create a new playlist podcast and associate it with the playlist
                var playlistPodcast = new PlaylistPodcast
                {
                    PlaylistId = playlistId,
                    PodcastId = podcastId,
                };

                db.PlaylistPodcasts.Add(playlistPodcast);
                db.SaveChanges();

                // Increment podcast quantity for the playlist
                playlist.PodcastQuantity++;

                db.SaveChanges();

                return Results.Created($"/api/addPodcastToPlaylist/{playlistId}/{podcastId}", playlistId);
            });

            // Delete Podcast from a Playlist
            app.MapDelete("/api/DeletePodcastFromPlaylist/{playlistId}/{podcastId}", (PodcastPlayerDbContext db, int playlistId, int podcastId) =>
            {
                var playlistPodcastToDelete = db.PlaylistPodcasts.SingleOrDefault(playlistPodcast => playlistPodcast.PlaylistId == playlistId && playlistPodcast.PodcastId == podcastId);

                if (playlistPodcastToDelete == null)
                {
                    return Results.NotFound("Podcast not found in the playlist.");
                }

                db.PlaylistPodcasts.Remove(playlistPodcastToDelete);
                db.SaveChanges();

                return Results.NoContent();
            });
        }
    }
}







