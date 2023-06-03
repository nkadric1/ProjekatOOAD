using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotifive.Models
{
    public class Editor : Person
    {   public Editor() { }
        public override Person Clone()
        {
            return (Editor)this.MemberwiseClone();
        }

    }
}