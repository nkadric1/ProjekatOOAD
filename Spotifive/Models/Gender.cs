using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Spotifive.Models
{
    public enum Gender
    {
		[Display(Name = "Male")]
		Male,
		[Display(Name = "Female")] 
		Female
    }
}
