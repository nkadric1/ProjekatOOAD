using System;
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
		////dodano
		///Song
		public string SongName { get; set; }
		public DateTime? DateRelease { get; set; }

		[EnumDataType(typeof(Genre))]
		public Genre Genre { get; set; }
		public string CodeQR { get; set; }
		public string LinkYT { get; set; }
		public string DriveLink { get; set; }
		public string Image { get; set; }
		public Review Review;
		public List<Review> Reviews { get; set; }

		//Artist
		public string ArtistName { get; set; }
		public string ArtistSurname { get; set; }
		//public string? Image { get; set; }

	}
}
