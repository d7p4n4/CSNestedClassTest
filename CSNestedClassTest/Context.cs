using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNestedClassTest
{
    class Context : DbContext
    {
        public Context() : base("try") { }

        public DbSet<Student> Students { get; set; }

    }
}
