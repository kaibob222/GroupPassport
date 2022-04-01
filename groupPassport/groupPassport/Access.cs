using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groupPassport.Classes;

namespace groupPassport
{
    class Access
    {
        internal Teacher GetUser(int _id)
        {
            Context context = new Context();
            Teacher user = context.Teachers
                .Where(g => g.Id == _id)
                .FirstOrDefault();

            return user;
        }
    }
}
