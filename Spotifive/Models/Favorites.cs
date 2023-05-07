using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Favorites
    {
        [Key] public int ID { get; set; }
        [ForeignKey("Playlist")] public int? PlaylistID { get; set; }
        [ForeignKey("Song")] public int? SongID { get; set; }
        public Song Song { get; set; }
        public Playlist Playlist { get; set; }
        public Favorites() { }
    }
}
