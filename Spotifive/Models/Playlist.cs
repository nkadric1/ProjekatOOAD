using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Playlist
    {
        [Key] public int ID { get; set; }
        public string PlaylistName { get; set; }
        public Playlist() { }
        public List<Song> Songs { get; set; }
    }
}
