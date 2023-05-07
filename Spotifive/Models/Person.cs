using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Spotifive.Models
{
    public abstract class Person
    {
        [Key] public int PersonID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateFormat DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Account Account { get; set; } 
        public Person() { }

    }
}
