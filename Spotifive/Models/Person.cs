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

		[EnumDataType(typeof(Gender))]
		public Gender Gender { get; set; }
        [ForeignKey("Account")] public int AccountID { get; set; }
        public Account Account { get; set; }
        public Person() { }
      
    }
}
