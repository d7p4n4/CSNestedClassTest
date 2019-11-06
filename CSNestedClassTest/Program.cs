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
                List<Grade> grades = new List<Grade>();
                grades.Add(new Grade("Math", 3));
                grades.Add(new Grade("History", 3));

                Student student = new Student()
                {
                    EnrollmentDate = DateTime.Today,
                    Identity = new Person("Jack", DateTime.Parse("1996-10-23")),
                    Grades = grades
                };

               ctx.Students.Add(student);
               ctx.SaveChanges();
                /*
                var s = ctx.Students
                            .Where(ss => ss.ID == 1)
                            .FirstOrDefault<Student>();

               var x = ctx.Grades.Where(gg => gg)

                var p = s.Identity;
                var grade = s.Grades;

                foreach(var g in grade)
                {
                    Console.WriteLine(g.Class);
                }

                Console.WriteLine(p.FatherName);*/
            }
        }
    }
}
