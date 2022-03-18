using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groupPassport.Classes;
using System.Data.Entity;


namespace groupPassport.TeacherForms
{
    class EditTeacherLogic
    {
        static public Teacher drop(Context C, int id)
        {
            var teacher = C.Teachers.Where(c => c.Id == id).FirstOrDefault();
            if (teacher != null)
            {
                return teacher;
            }
            return null;
        }

        static public void apply(Context C, int id, string surname, string firtsname, string middlename, string password,Position position)
        {
            var teacher = C.Teachers.Where(c => c.Id == id).FirstOrDefault();
            if (teacher != null)
            {
                teacher.SurName = surname;
                teacher.FirstName = firtsname;
                teacher.MiddleName = middlename;
                teacher.Password = password;
                teacher.Position = position;
                C.Entry(teacher).State = EntityState.Modified;
                C.SaveChanges();
            }
        }
    }
}
