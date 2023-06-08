using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Playlist
    {
        [Key] public int ID { get; set; }
        public string PlaylistName { get; set; }
		[ForeignKey("ApplicationUser")] public string Uid { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Playlist() { }
        

    }
}
