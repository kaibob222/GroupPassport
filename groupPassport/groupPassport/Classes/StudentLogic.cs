using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace groupPassport.Classes
{
    public class StudentLogic
    {
        public static void AddStudent(string fName, string sName, string mName, int groupId)
        {
            var C = new Context();
            var student = new Student();
            student.FirstName = fName;
            student.SurName = sName;
            student.MiddleName = mName;
            student.Login = fName + sName + mName;
            student.Password = "password";
            student.GroupId = groupId;

            C.Students.Add(student);
            C.SaveChanges();
        }
        public static void EditStudent(int id, string fName, string sName, string mName)
        {
            var C = new Context();
            var student = C.Students.Where(c => c.Id == id).FirstOrDefault();

            student.FirstName = fName;
            student.SurName = sName;
            student.MiddleName = mName;

            C.Entry(student).State = EntityState.Modified;
            C.SaveChanges();

        }
        public static void DeleteStudent(int id, int groupid)
        {
            var C = new Context();
            var student = C.Students.Where(c => c.Id == id).FirstOrDefault();
            student.GroupId = null;

            C.Entry(student).State = EntityState.Modified;

            C.SaveChanges();
        }
    }
}
