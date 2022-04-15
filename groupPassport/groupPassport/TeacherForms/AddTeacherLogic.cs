using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groupPassport.Classes;

namespace groupPassport.TeacherForms
{
    class AddTeacherLogic
    {
        public static void AddTeacher(string Surname,string Firstname,string Middlename,string Login,string Password,Classes.Position position, List<Group> groups)
        {
            Context c = new Context();

            Classes.Teacher p = new Classes.Teacher ();
            p.FirstName = Firstname;
            p.SurName = Surname;
            p.MiddleName = Middlename;
            p.Login = Login;
            p.Password = Password;
            p.Position = position;
            //foreach (var item in groups)
            //{
            //    p.Groups = item.ToString();
            //}
            List<Group> gs = new List<Group>();
            foreach(Group group in groups)
            {
                gs.Add(c.Groups.Find(group.Id));
            }
            p.Groups.AddRange(gs);
            c.Teachers.Add(p);
            c.SaveChanges();
        }
    }
}
