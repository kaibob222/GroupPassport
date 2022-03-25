using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupPassport
{
    public class DeleteTeacherLogic
    {
        public static void DeleteTeacher(int id)
        {
            Context context = new Context();

            Classes.Teacher order = context.Teachers
                .Where(o => o.Id == id)
                .FirstOrDefault();

            context.Teachers.Remove(order);
            context.SaveChanges();
        }
    }
}
