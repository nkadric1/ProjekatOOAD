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

        [ForeignKey("Administrator")] public int? AdminID { get; set; }
        public Administrator Administrator { get; set; }
        public Account() { }
    }
}
