using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNestedClassTest
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public Person Identity { get; set; }

        public ICollection<Grade> Grades { get; set; }


       
    }
}
