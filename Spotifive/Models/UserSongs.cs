using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Spotifive.Models
{
    public class UserSongs
    {
        [Key] public int ID { get; set; }
        [ForeignKey("RegisteredUser")] public int UserID { get; set; }
        [ForeignKey("Song")] public int SongID { get; set; }
        public Song Song { get; set; }
        public RegisteredUser RegisteredUser { get; set; }
        public UserSongs() { }
    }
}
