using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Spotifive.Models
{
    public class Song
    {
        [Key] public int ID { get; set; }
        public string SongName { get; set; }
        public DateTime? DateRelease { get; set; }
        public Genre Genre { get; set; }    
        public string CodeQR { get; set; }
        public string LinkYT { get; set; }
        public string Image { get; set; }
        public Song() { }
    }
}
