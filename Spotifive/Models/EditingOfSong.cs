using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class EditingOfSong
    {
        [Key] public int ID { get; set; }
        [ForeignKey("Editor")] public int? EditorID { get; set; }
        [ForeignKey("Song")] public int? SongID { get; set; }
        public Song Song { get; set; }
        public Editor Editor { get; set; }
        public EditingOfSong() { }
    }
}
