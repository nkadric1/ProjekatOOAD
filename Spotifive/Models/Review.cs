
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Review
    {
        [Key] public int ID { get; set; }
        public double Grade { get; set; }
        public string Comment { get; set; }
        public string TimeStamp { get; set; }
        [ForeignKey("Critic")] public int CriticID { get; set; }
        [ForeignKey("Song")] public int SongID { get; set; }
       public Song Song { get; set; }
       public  Critic User { get; set; }
        public Review() { }
    }
}
