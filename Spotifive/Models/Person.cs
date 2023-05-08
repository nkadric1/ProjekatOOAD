using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Spotifive.Models
{
    public abstract class Person
    {
        [Key] public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Account Account { get; set; } 
        public Person() { }
      
    }
}
