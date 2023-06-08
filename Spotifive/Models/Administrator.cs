using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Administrator : ApplicationUser
         {       public Administrator() { }
        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }
     /*   public override Person Clone()
        {
           
            Administrator aUser = (Administrator)this.MemberwiseClone();
            aUser.Name = (string)this.Name.Clone();
            aUser.Surname = (string)this.Surname.Clone();
            aUser.DateOfBirth = (DateTime)this.DateOfBirth;
            aUser.Gender = (Gender)((int)this.Gender);
            return aUser;
        }*/

    }
}
