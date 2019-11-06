using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNestedClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = new Context())
            {
                Student student = new Student()
                {
                    EnrollmentDate = DateTime.Today,
                    Identity = new Student.Person("Jack", DateTime.Parse("1996-10-23"))
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
