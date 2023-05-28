using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Person
    {
        [Key] public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        [ForeignKey("Account")] public int AccountID { get; set; }
        public Account Account { get; set; }
        public Person() { }
        //implementation of prototype pattern

        public virtual Person Clone()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.Name = String.Copy(Name);
            clone.Surname = String.Copy(Surname);
            clone.Gender = Gender;
            return clone;
        }
      
    }
}
