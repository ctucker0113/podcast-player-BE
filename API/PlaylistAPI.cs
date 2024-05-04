using podcast_player_BE.API;
using podcast_player_BE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace podcast_player_BE.API
{
    public static class PlaylistAPI
    {
        public static void Map(WebApplication app)
        {
            // Create Playlist
            app.MapPost("/api/createPlaylist", (PodcastPlayerDbContext db, Playlist newPlaylist) =>
            {
                db.Playlists.Add(newPlaylist);
                db.SaveChanges();
                return Results.Created($"/api/createPlaylist/{newPlaylist.Id}", newPlaylist);
            });

            // Get All Playlists
            app.MapGet("/api/getAllPlaylists", (PodcastPlayerDbContext db) =>
            {
                return db.Playlists.ToList();
            });

            // Get Single Playlist
            app.MapGet("/api/getSinglePlaylist/{id}", (PodcastPlayerDbContext db, int id) =>
            {
                var playlist = db.Playlists.FirstOrDefault(p => p.Id == id);

                if (playlist == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(playlist);
            });

            // Get Users Playlist
            app.MapGet("/api/getAllUserPlaylists/{userId}", (PodcastPlayerDbContext db, int userId) =>
            {
                var playlists = db.Playlists.Where(p => p.OwnerID == userId).ToList();

                if (playlists == null || playlists.Count == 0)
                {
                    return Results.NotFound("No playlists found for this user.");
                }

                return Results.Ok(playlists);
            });


            // Update Playlist Title or Image
            app.MapPatch("/api/updatePlaylist/{id}", (PodcastPlayerDbContext db, int id, Playlist updatedPlaylist) =>
            {
                Playlist playlistToUpdate = db.Playlists.SingleOrDefault(Playlist => Playlist.Id == id);

                if (playlistToUpdate == null)
                {
                    return Results.NotFound();
                }

                playlistToUpdate.Title = updatedPlaylist.Title;
                playlistToUpdate.Image = updatedPlaylist.Image;

                db.SaveChanges();
                return Results.NoContent();
            });

            // Increment podcastQuantity for a Playlist
            app.MapPatch("/api/incrementPodcastQuantity/{id}", (PodcastPlayerDbContext db, int id) =>
            {
                var playlistToUpdate = db.Playlists.SingleOrDefault(p => p.Id == id);

                if (playlistToUpdate == null)
                {
                    return Results.NotFound();
                }

                playlistToUpdate.PodcastQuantity += 1;

                db.SaveChanges();
                return Results.Ok(playlistToUpdate.PodcastQuantity);
            });


            // Decrement podcastQuantity for a Playlist
            app.MapPatch("/api/decrementPodcastQuantity/{id}", (PodcastPlayerDbContext db, int id) =>
            {
                var playlistToUpdate = db.Playlists.SingleOrDefault(p => p.Id == id);

                if (playlistToUpdate == null)
                {
                    return Results.NotFound();
                }

                if (playlistToUpdate.PodcastQuantity > 0)
                {
                    playlistToUpdate.PodcastQuantity -= 1;
                    db.SaveChanges();
                    return Results.Ok(playlistToUpdate.PodcastQuantity);
                }
                else
                {
                    return Results.BadRequest("Podcast quantity cannot be less than zero.");
                }
            });

            // Delete Playlist
            app.MapDelete("/api/deletePlaylist/{id}", (PodcastPlayerDbContext db, int id) =>
            {
                var playlist = db.Playlists.Find(id);
                if (playlist == null) return Results.NotFound();

                db.Playlists.Remove(playlist);
                db.SaveChanges();
                return Results.NoContent();
            });

            // Get Single Playlist by Playlist Title
            app.MapGet("/api/getSinglePlaylistByTitle/{title}", (PodcastPlayerDbContext db, string title) =>
            {
                var PlaylistTitle = db.Playlists.FirstOrDefault(c => c.Title == title);

                if (PlaylistTitle == null)
                {
                    return Results.NotFound("Playlist Not Found.");
                }

                return Results.Ok(PlaylistTitle);
            });
        }
    }
}