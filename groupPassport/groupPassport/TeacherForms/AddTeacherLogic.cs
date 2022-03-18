using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupPassport.TeacherForms
{
    class AddTeacherLogic
    {
        public static void AddTeacher(string Surname,string Firstname,string Middlename,string Login,string Password,Classes.Position position)
        {
            Context c = new Context();

            Classes.Teacher p = new Classes.Teacher ();
            p.FirstName = Firstname;
            p.SurName = Surname;
            p.MiddleName = Middlename;
            p.Login = Login;
            p.Password = Password;
            p.Position = position;
            c.Teachers.Add(p);
            c.SaveChanges();
        }
    }
}
