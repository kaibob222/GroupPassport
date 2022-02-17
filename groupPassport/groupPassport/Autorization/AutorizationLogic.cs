using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupPassport
{
    class AutorizationLogic
    {
        internal List<dynamic> GetPeopleList(Context context, string login, string password)
        {

            var groups = context.People
                .Where(g => g.Login == login && g.Password == password)
                .Select(g => new { Id = g.Id, Name = g.Login })
                .ToList<dynamic>();

            if (groups == null)
                return null;
            else
                return groups;
        }
    }
}
