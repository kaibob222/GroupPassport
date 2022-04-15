﻿using System;
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
