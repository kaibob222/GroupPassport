using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace groupPassport.Classes
{
    class GroupLogic
    {
        public static void AddGroup(string name, int year)
        {
            Context c = new Context();
            Group g = new Group();
            g.GroupName = name;
            g.Year = year;
            c.Groups.Add(g);
            c.SaveChanges();
        }

        public static void DeleteGroup(int id)
        {
            Context context = new Context();

            Group order = context.Groups
                .Where(o => o.Id == id)
                .FirstOrDefault();

            context.Groups.Remove(order);
            context.SaveChanges();
        }

        static public Group DropEditData(Context C, int id)
        {
            var group = C.Groups.Where(c => c.Id == id).FirstOrDefault();
            if (group != null)
            {
                return group;
            }
            return null;
        }
        static public void ApplyEditChanges(Context C, int id, string name, int year)
        {
            var group = C.Groups.Where(c => c.Id == id).FirstOrDefault();
            if (group != null)
            {
                group.GroupName = name;
                group.Year = year;
                C.Entry(group).State = EntityState.Modified;
                C.SaveChanges();
            }
        }
    }
}
