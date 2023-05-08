using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Critic : Person
    {
       
        public Critic() { }

        [ForeignKey("Artist")] public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}
