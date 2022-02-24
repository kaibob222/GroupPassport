using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupPassport
{
    class AutorizationLogic
    {
        internal Person GetPeopleList(string login, string password)
        {
            Context context = new Context();
            Person person = context.People
                .Where(g => g.Login == login && g.Password == password)
                .FirstOrDefault();

                return person;
        }
    }
}
