﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Editor : Person
    {   public Editor() { }
        [ForeignKey("Song")] public int SongID { get; set; }
        public Song Song { get; set; }
        [ForeignKey("Artist")] public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}