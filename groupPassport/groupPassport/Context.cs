using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using groupPassport.Classes;

namespace groupPassport
{
    public class Context : DbContext
    {
        public Context() : base("ConnStr") { }

        public DbSet<Person> People { get; set; }

        public DbSet<Group> Groups { get; set; }

    }

}

