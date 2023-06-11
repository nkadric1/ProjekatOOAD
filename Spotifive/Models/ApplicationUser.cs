
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Spotifive.Models
{
    public class ApplicationUser : IdentityUser
    {
        public override string Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }
		[EnumDataType(typeof(Gender))]
		public Gender Gender { get; set; }
       
        public string Role { get; set; }


        public ApplicationUser() { }



    }
}
