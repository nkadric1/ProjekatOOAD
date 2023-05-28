using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class RegisteredUser : Person
    {
     public RegisteredUser() { }
        [ForeignKey("Song")] public int SongID { get; set; }
        public Song Song { get; set; }
        //implementation of prototype pattern
        public override Person Clone()
        {
            return (RegisteredUser)this.MemberwiseClone();
        }

    }
}
