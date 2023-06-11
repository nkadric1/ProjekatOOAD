using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Spotifive.Models
{
	public enum Genre
    {

		[Display(Name = "Pop")]
		Pop,
		[Display(Name = "Rock")]
		Rock,
		[Display(Name = "Folk")]
		Folk,
		[Display(Name = "Metal")]
		Metal,
		[Display(Name = "Country")]
		Country,
		[Display(Name = "Jazz")]
		Jazz,
		[Display(Name = "Classical")]
		Classical,
		[Display(Name = "Traditional")]
		Traditional,
		[Display(Name = "RnB")]
		RnB
	}
}
