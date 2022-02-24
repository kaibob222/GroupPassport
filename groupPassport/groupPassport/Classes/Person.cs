using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace groupPassport
{
    public class Person
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public String FirstName { get; set; }
        [MaxLength(50)]
        public String SurName { get; set; }
        [MaxLength(50)]
        public String MiddleName { get; set; }

        [MaxLength(20)]
        public String Login { get; set; }
        [MaxLength(20)]
        public String Password { get; set; }

    }
}
