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
        public static void AddExistStudent(int id, int groupId)
        {
            var C = new Context();
            var student = C.Students.Where(c => c.Id == id).FirstOrDefault();
            student.GroupId = groupId;

            C.Entry(student).State = EntityState.Modified;
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

        public static List<Student> FilterNameStudent(string s, int groupId)
        {
            var C = new Context();
            List<Student> filteredStudents = new List<Student>();
            List<string> arr = s.Split(' ').ToList();
            arr.Remove("");
            if (s.Contains(' '))
            {
                if (arr.Count == 1) filteredStudents = C.Students.Where(c => c.GroupId == groupId && (arr.Contains(c.FirstName) || arr.Contains(c.MiddleName) || arr.Contains(c.SurName))).ToList();

                if (arr.Count == 2) filteredStudents = C.Students.Where(c => c.GroupId == groupId && 
                ((arr.Contains(c.FirstName) && (arr.Where(a => c.MiddleName.StartsWith(a)).ToList().Count != 0 || arr.Where(a => c.SurName.StartsWith(a)).ToList().Count != 0)) ||
                (arr.Contains(c.MiddleName) && (arr.Where(a => c.FirstName.StartsWith(a)).ToList().Count != 0 || arr.Where(a => c.SurName.StartsWith(a)).ToList().Count != 0)) ||
                (arr.Contains(c.SurName) && (arr.Where(a => c.FirstName.StartsWith(a)).ToList().Count != 0 || arr.Where(a => c.MiddleName.StartsWith(a)).ToList().Count != 0))
                )).ToList();

                if (arr.Count == 3) filteredStudents = C.Students.Where(c => c.GroupId == groupId &&
                ((arr.Contains(c.FirstName) && arr.Contains(c.MiddleName) && arr.Where(a => c.SurName.StartsWith(a)).ToList().Count != 0) ||
                (arr.Contains(c.MiddleName) && arr.Contains(c.SurName) && arr.Where(a => c.FirstName.StartsWith(a)).ToList().Count != 0) ||
                (arr.Contains(c.SurName) && arr.Contains(c.FirstName) && arr.Where(a => c.MiddleName.StartsWith(a)).ToList().Count != 0)
                )).ToList();
            }
            else
            {
                filteredStudents = C.Students.Where(c => c.GroupId == groupId && (c.FirstName.Contains(s) || c.MiddleName.Contains(s) || c.SurName.Contains(s))).ToList();
            }
            return filteredStudents;
        }

        public static List<Student> FilterDateStudent(DateTime date, int groupId)
        {
            var C = new Context();
            //var filterStudents = C.Students.Where(c => c.);
            return null;
        }

        public static List<Student> FilterBookStudent(int num, int groupId)
        {
            var C = new Context();
            string bookNum = num.ToString();

            var filteredStudents = C.Students.Where(c => c.GroupId == groupId && c.Documents.Find(r => r.DocumentType == DocumentType.inn).DocumentNumber.Contains(bookNum)).ToList();
            return filteredStudents;
        }
    }
}
