using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Spotifive.Models
{
    public class Artist
    {
        [Key] public int ID { get; set; }
        public string ArtistName { get; set; }
        public string ArtistSurname { get; set; }
        public string? Image {  get; set; }
        public Artist() { }
    }
}
