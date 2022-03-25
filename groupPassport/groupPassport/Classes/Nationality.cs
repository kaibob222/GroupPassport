using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupPassport.Classes
{
    public class Nationality
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string PersonNationality { get; set; }
    }
}
