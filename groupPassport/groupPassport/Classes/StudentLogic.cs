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
        public static void AddStudent(string fName, string sName, string mName, int groupId, string gender, groupPassport.Classes.Nationality nationality, groupPassport.Classes.Citizenship citizenship, string militaryService, string educationForm, string education, string zachNumber, DateTime birthDate)
        {
            var C = new Context();
            var student = new Student();
            student.FirstName = fName;
            student.SurName = sName;
            student.MiddleName = mName;
            student.Login = fName + sName + mName;
            student.Password = "password";
            student.GroupId = groupId;
            student.BirthDate = birthDate;
            student.CitizenshipId = citizenship.Id;

            student.Gender = (Gender)Enum.Parse(typeof(Gender), gender, true);
            student.Education = (Education)Enum.Parse(typeof(Education), education, true);
            student.FormEducation = (FormEducation)Enum.Parse(typeof(FormEducation), educationForm, true);
            student.MilitaryService = (MilitaryService)Enum.Parse(typeof(MilitaryService), militaryService, true);

            student.NationalityId = nationality.Id;
            student.ZachetkaNumber = zachNumber;

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
        public static void EditStudent(int id, string fName, string sName, string mName, string gender, groupPassport.Classes.Nationality nationality, groupPassport.Classes.Citizenship citizenship, string militaryService, string educationForm, string education,string zachNumber, DateTime birthDate)
        {
            var C = new Context();
            var student = C.Students.Where(c => c.Id == id).FirstOrDefault();

            student.FirstName = fName;
            student.SurName = sName;
            student.MiddleName = mName; 
            student.BirthDate = birthDate;
            student.CitizenshipId = citizenship.Id;

            student.Gender = (Gender)Enum.Parse(typeof(Gender), gender, true);
            student.Education = (Education)Enum.Parse(typeof(Education), education, true);
            student.FormEducation = (FormEducation)Enum.Parse(typeof(FormEducation), educationForm, true);
            student.MilitaryService = (MilitaryService)Enum.Parse(typeof(MilitaryService), militaryService, true);

            student.NationalityId = nationality.Id;
            student.ZachetkaNumber = zachNumber;

            C.Entry(student).State = EntityState.Modified;
            C.SaveChanges();
        }
        public static void DeleteStudent(int id)
        {
            var C = new Context();
            var student = C.Students.Where(c => c.Id == id).FirstOrDefault();
            student.GroupId = null;

            C.Entry(student).State = EntityState.Modified;

            C.SaveChanges();
        }

        public static List<Student> FilterNameStudent(List<Student> studentsData, string s)
        {
            var filteredStudents = studentsData;
            List<string> arr = s.Split(' ').ToList();
            arr.Remove("");
            if (s.Contains(' '))
            {
                if (arr.Count == 1) filteredStudents = filteredStudents.Where(c => (arr.Contains(c.FirstName) || arr.Contains(c.MiddleName) || arr.Contains(c.SurName))).ToList();

                if (arr.Count == 2)
                {
                    if (s.EndsWith(" "))
                    {
                        filteredStudents = filteredStudents.Where(c =>
                (arr.Contains(c.FirstName) && arr.Contains(c.MiddleName)) ||
                (arr.Contains(c.MiddleName) && arr.Contains(c.SurName)) ||
                (arr.Contains(c.SurName) && arr.Contains(c.FirstName))
                ).ToList();
                    }
                    else
                    {
                        filteredStudents = filteredStudents.Where(c =>
                (arr.Contains(c.FirstName) && (arr.Where(a => c.MiddleName.StartsWith(a)).ToList().Count != 0 || arr.Where(a => c.SurName.StartsWith(a)).ToList().Count != 0)) ||
                (arr.Contains(c.MiddleName) && (arr.Where(a => c.FirstName.StartsWith(a)).ToList().Count != 0 || arr.Where(a => c.SurName.StartsWith(a)).ToList().Count != 0)) ||
                (arr.Contains(c.SurName) && (arr.Where(a => c.FirstName.StartsWith(a)).ToList().Count != 0 || arr.Where(a => c.MiddleName.StartsWith(a)).ToList().Count != 0))
                ).ToList();
                    }
                }

                if (arr.Count == 3)
                {
                    if (!s.EndsWith(" ")) {
                        filteredStudents = filteredStudents.Where(c =>
                (arr.Contains(c.FirstName) && arr.Contains(c.MiddleName) && arr.Where(a => c.SurName.StartsWith(a)).ToList().Count != 0) ||
                (arr.Contains(c.MiddleName) && arr.Contains(c.SurName) && arr.Where(a => c.FirstName.StartsWith(a)).ToList().Count != 0) ||
                (arr.Contains(c.SurName) && arr.Contains(c.FirstName) && arr.Where(a => c.MiddleName.StartsWith(a)).ToList().Count != 0)
                ).ToList();
                    }
                    else
                    {
                        filteredStudents = filteredStudents.Where(c =>
                arr.Contains(c.FirstName) && arr.Contains(c.MiddleName) && arr.Contains(c.SurName)
                ).ToList();
                    }
                }
            }
            else
            {
                filteredStudents = filteredStudents.Where(c => (c.FirstName.Contains(s) || c.MiddleName.Contains(s) || c.SurName.Contains(s))).ToList();
            }
            return filteredStudents;
        }

        public static List<Student> FilterDateStudent(List<Student> studentsData, DateTime date)
        {
            var filteredStudents = new List<Student>();
            
            filteredStudents = studentsData.Where(c => c.BirthDate.Date == date).ToList();

            return filteredStudents;
        }

        public static List<Student> FilterBookStudent(List<Student> studentsData, string s)
        {
            var filteredStudents = new List<Student>();
            
            if (s.Length < 6)
            {
                filteredStudents = studentsData.Where(c => c.ZachetkaNumber.StartsWith(s)).ToList();
            }
            else if (s.Length == 6)
            {
                filteredStudents = studentsData.Where(c => c.ZachetkaNumber == s).ToList();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Неправильная длина номера");
            }
            return filteredStudents;
        }
    }
}
