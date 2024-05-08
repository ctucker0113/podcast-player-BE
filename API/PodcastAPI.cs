using podcast_player_BE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace podcast_player_BE.API
{
    public static class PodcastAPI
    {
        public static void Map(WebApplication app)
        {
            // Get All Podcasts
            app.MapGet("/api/getAllPodcasts", (PodcastPlayerDbContext db) =>
            {
                return db.Podcasts.ToList();
            });

            // Get Single Podcast
            app.MapGet("/api/getSinglePodcast/{id}", (PodcastPlayerDbContext db, int id) =>
            {
                var PodcastID = db.Podcasts.FirstOrDefault(c => c.Id == id);

                if (PodcastID == null)
                {
                    return Results.NotFound("Podcast Not Found.");
                }

                return Results.Ok(PodcastID);
            });

            // Update Podcast
            app.MapPatch("/api/updatePodcast/{id}", (PodcastPlayerDbContext db, int id, Podcast updatePodcast) =>
            {
                Podcast podcastToUpdate = db.Podcasts.SingleOrDefault(Podcast => Podcast.Id == id);
                if (podcastToUpdate == null)
                {
                    return Results.NotFound();
                }
                podcastToUpdate.Name = updatePodcast.Name;
                podcastToUpdate.Image = updatePodcast.Image;
                podcastToUpdate.Favorite = updatePodcast.Favorite;
                db.SaveChanges();
                return Results.NoContent();
            });
            app.MapPost("/api/createPodcast", (PodcastPlayerDbContext db, Podcast newPodcast) =>
            {
                db.Podcasts.Add(newPodcast);
                db.SaveChanges();
                return Results.Created($"/api/createPodcast/{newPodcast.Id}", newPodcast);
            });
            app.MapDelete("/api/deletePodcast/{id}", (PodcastPlayerDbContext db, int id) =>
            {
                var podcast = db.Podcasts.Find(id);
                if (podcast == null) return Results.NotFound();
                db.Podcasts.Remove(podcast);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
