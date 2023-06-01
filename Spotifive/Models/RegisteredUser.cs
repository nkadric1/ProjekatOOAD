using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class RegisteredUser : Person
    {
     public RegisteredUser() { }
  
        //implementation of prototype pattern
        public override Person Clone()
        {
            return (RegisteredUser)this.MemberwiseClone();
        }

    }
}
