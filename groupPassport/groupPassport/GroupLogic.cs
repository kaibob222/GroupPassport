using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groupPassport.Classes;
using System.Data.Entity;

namespace groupPassport
{
    class GroupLogic
    {
        static public Group drop(Context C, int id)
        {
            var group = C.Groups.Where(c => c.Id == id).FirstOrDefault();
            if (group != null)
            {
                return group;
            }
            return null;
        }

        static public void apply(Context C, int id, string name, int year)
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
