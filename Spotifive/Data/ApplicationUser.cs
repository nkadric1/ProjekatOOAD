
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Spotifive.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Spotifive.Data
{
    public class ApplicationUser: IdentityUser
	{
		
		public string Name { get; set; }
	
		public string Surname { get; set; }
	
		public DateTime DateOfBirth { get; set; }
		public Gender Gender { get; set; }
	
		public string Role { get; set; }

		public ApplicationUser() { }
		


	}
}
