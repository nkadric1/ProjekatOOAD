using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Spotifive.Models
{
    public class PlaylistSongs
    {
        [Key] public int ID { get; set; }
        [ForeignKey("Playlist")] public int PlaylistID { get; set; }
        [ForeignKey("Song")] public int SongID { get; set; }
        public Playlist Playlist{ get; set; }
        public Song Song{ get; set; }
        public PlaylistSongs() { }
    }
}
