using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace groupPassport.Classes
{
    public class Student : Person
    {
        public int? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }
        public virtual List<Document> Documents { get; set; }
        [MaxLength(6)]
        public string ZachetkaNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public MilitaryService MilitaryService { get; set; }
        public FormEducation FormEducation { get; set; }
        public Education Education { get; set; }
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public int CitizenshipId { get; set; }
        public Citizenship Citizenship { get; set; }
    }
}
