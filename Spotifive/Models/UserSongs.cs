using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Spotifive.Models
{
    public class UserSongs
    {
        [Key] public int ID { get; set; }
		[ForeignKey("ApplicationUser")] public string Uid { get; set; }
		public ApplicationUser ApplicationUser { get; set; }
		[ForeignKey("Song")] public int SongID { get; set; }
        public Song Song { get; set; }
    
        public UserSongs() { }
    }
}
