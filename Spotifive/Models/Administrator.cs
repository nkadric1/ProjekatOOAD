using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Spotifive.Models
{
    public class Administrator : Person
         {       public Administrator() { }
                 public List<Account> Accounts { get; set; }
                
    }
}
