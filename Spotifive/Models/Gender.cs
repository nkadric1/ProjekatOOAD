using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace Spotifive.Models
{
    public enum Gender
    {
		[Display(Name = "Female")]
		Female,
		[Display(Name = "Male")]
		Male
		
    }
}
