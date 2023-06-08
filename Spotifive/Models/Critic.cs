using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Critic : ApplicationUser
    {       
        public Critic() { }
		[ForeignKey("ApplicationUser")]
		public string UserID { get; set; }
		/*  public override Person Clone()
		  {
			  Critic cUser = (Critic)this.MemberwiseClone();
			  cUser.Name = (string)this.Name.Clone();
			  cUser.Surname = (string)this.Surname.Clone();
			  cUser.DateOfBirth = (DateTime)this.DateOfBirth;
			  cUser.Gender = (Gender)((int)this.Gender);
			  return cUser;
		  }
		*/
	}
}
