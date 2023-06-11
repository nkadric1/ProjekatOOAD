using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Review
    {
        [Key] public int ID { get; set; }
        [Required]
        [Range(1.0, 5.0, ErrorMessage =
            "Rating must be between 1.0 and 5.0!")]
        public double Grade { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage =
"Comment can be between 3 and 50 characters!")]
        public string Comment { get; set; }
        public string TimeStamp { get; set; }
       
        [ForeignKey("Song")] public int SongID { get; set; }
        public Song Song { get; set; }
		[ForeignKey("ApplicationUser")] public string Uid { get; set; }
		public ApplicationUser ApplicationUser { get; set; }
		public Review() { }
    }
}
