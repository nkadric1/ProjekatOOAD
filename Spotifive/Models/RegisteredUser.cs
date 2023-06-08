using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class RegisteredUser : ApplicationUser
    {
     public RegisteredUser() { }
		[ForeignKey("ApplicationUser")]
		public string UserID { get; set; }

	

		//implementation of prototype pattern
		/*  public override Person Clone()
		  {    

				  RegisteredUser rUser=(RegisteredUser)this.MemberwiseClone();
				  rUser.Name = (string)this.Name.Clone();
			  rUser.Surname = (string)this.Surname.Clone();
			  rUser.DateOfBirth = (DateTime)this.DateOfBirth;
			  rUser.Gender = (Gender)((int)this.Gender);
			  return rUser;	
		  }*/

	}
}
