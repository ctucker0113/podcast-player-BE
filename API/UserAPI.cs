using podcast_player_BE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace podcast_player_BE.API
{
    public static class UserAPI
    {
        public static void Map(WebApplication app)
        {
            //Check Users
            app.MapGet("/checkUser/{uid}", (PodcastPlayerDbContext db, string uid) =>
            {
                var user = db.Users.Where(x => x.Uid == uid).ToList();

                if (uid == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(user);
                }
            });
        }
    }
}
