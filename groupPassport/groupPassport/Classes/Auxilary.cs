using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupPassport.Classes
{
    class Auxilary
    {
        public static void AddNationality(string name)
        {
            Context c = new Context();
            Nationality g = new Nationality();
            g.PersonNationality = name;
            c.Nationalities.Add(g);
            c.SaveChanges();
        }

        public static void AddCitizenship(string name)
        {
            Context c = new Context();
            Citizenship g = new Citizenship();
            g.PersonCitizenship = name;
            c.Citizenships.Add(g);
            c.SaveChanges();
        }

        public static void AddDocument(string name, string doc_type, int student)
        {
            Context c = new Context();
            Document g = new Document();
            g.DocumentType = (DocumentType)Enum.Parse(typeof(DocumentType), doc_type);
            g.DocumentNumber = name;
            g.StudentId = student;
            c.Documents.Add(g);
            c.SaveChanges();
        }

        public static void DeleteNationality(int id)
        {
            Context context = new Context();

            Nationality order = context.Nationalities
                .Where(o => o.Id == id)
                .FirstOrDefault();

            context.Nationalities.Remove(order);
            context.SaveChanges();
        }

        public static void DeleteCitizenship(int id)
        {
            Context context = new Context();

            Citizenship order = context.Citizenships
                .Where(o => o.Id == id)
                .FirstOrDefault();

            context.Citizenships.Remove(order);
            context.SaveChanges();
        }

        public static void DeleteDocument(int id)
        {
            Context context = new Context();

            Document order = context.Documents
                .Where(o => o.Id == id)
                .FirstOrDefault();

            context.Documents.Remove(order);
            context.SaveChanges();
        }
    }
}
