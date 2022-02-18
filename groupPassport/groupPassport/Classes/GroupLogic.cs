using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
