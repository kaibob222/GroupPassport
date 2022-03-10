using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupPassport.Classes
{
    
    public class Document
    {
        public int Id { get; set; }
        public DocumentType DocumentType { get; set; }
        [MaxLength(50)]
        public string DocumentNumber { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
