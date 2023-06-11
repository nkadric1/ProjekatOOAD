﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class ArtistSongs
    {
        [Key] public int ID { get; set; }
        [ForeignKey("Artist")] public int ArtistID { get; set; }
        [ForeignKey("Song")] public int SongID { get; set; }
        public Song Song { get; set; }
        public Artist Artist { get; set; }
        public ArtistSongs() { }
		
	}
}
