using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class EditingOfArtist
    {
        [Key] public int ID { get; set; }
        [ForeignKey("Artist")] public int? ArtistID { get; set; }
        [ForeignKey("Editor")] public int? EditorID { get; set; }
        public Editor Editor { get; set; }
        public Artist Artist { get; set; }
        public EditingOfArtist() { }
    }
}
