using Spotifive.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Account
    {
        [Key] public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ImageM { get; set; }
        public string ImageF { get; set; }
		[ForeignKey("ApplicationUser")] public int UserID { get; set; }
		public ApplicationUser User { get; set; }
		public Account() { }
    }
}
