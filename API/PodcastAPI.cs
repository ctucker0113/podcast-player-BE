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
        }
    }
}
