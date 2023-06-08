using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Spotifive.Models
{
    public class EditorSongs
    {
        [Key] public int ID { get; set; }
        [ForeignKey("Song")] public int SongID { get; set; }
        public Song Song { get; set; }
		public Editor Editor { get; set; }
		public EditorSongs() { }
    }
}
