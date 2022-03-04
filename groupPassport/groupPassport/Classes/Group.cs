using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupPassport.Classes
{
    public class Group
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string GroupName { get; set; }
        [Range(2015, 2100)]
        public int Year { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
    }
}
