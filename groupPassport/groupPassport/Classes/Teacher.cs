using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace groupPassport.Classes
{
    public enum Position
    {
        [Description("Админ")]
        admin,
        [Description("Старший преподаватель")]
        lecturer,
        [Description("Доцент")]
        docent,
        [Description("Профессор")]
        professor
    }
    public class Teacher : Person
    {

        public Position Position { get; set; } //Должность
        public virtual List<Group> Groups { get; set; }
       
    }
}
