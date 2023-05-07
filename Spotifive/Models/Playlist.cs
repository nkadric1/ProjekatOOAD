using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Playlist
    {
        [Key] public int ID { get; set; }
        public string PlaylistName { get; set; }
        [ForeignKey("RegisteredUser")] public int UserID { get; set; }
        public RegisteredUser User { get; set; }
        public Playlist() { }
    }
}
