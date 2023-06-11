using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Playlist
    {
        [Key] public int ID { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage =
"Playlist name must be between 3 and 50 characters!")]
        [RegularExpression(@"[0-9| |a-z|A-Z]*", ErrorMessage =
            "It's allowed only to use upper and lower case letters, numbers and spaces!")]
        [DisplayName("Playlist name:")]
        public string PlaylistName { get; set; }
		[ForeignKey("ApplicationUser")] public string Uid { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Playlist() { }
        

    }
}
