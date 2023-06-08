using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Editor : ApplicationUser
    {   public Editor() { }

		[ForeignKey("ApplicationUser")]
		public string UserID { get; set; }
		/*public override Person Clone()
        {
            Editor eUser = (Editor)this.MemberwiseClone();
            eUser.Name = (string)this.Name.Clone();
            eUser.Surname = (string)this.Surname.Clone();
            eUser.DateOfBirth = (DateTime)this.DateOfBirth;
            eUser.Gender = (Gender)((int)this.Gender);
            return eUser;
        }*/

	}
}