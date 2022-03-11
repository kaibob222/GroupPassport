using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace groupPassport.Classes
{
    public class Teacher : Person
    {
        [MaxLength(20)]
        public string Position { get; set; } //Должность
        public virtual List<Group> Groups { get; set; }
       
    }
}
