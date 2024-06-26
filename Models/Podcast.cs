﻿using System.ComponentModel.DataAnnotations;

namespace podcast_player_BE.Models
{
    public class Podcast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }
        public bool Favorite { get; set; }
    }
}
