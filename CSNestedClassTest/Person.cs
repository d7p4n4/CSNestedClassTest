using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNestedClassTest
{
    public class Person
    {
        public Person() { }

        public Person(string fatherName, DateTime birthDate)
        {
            FatherName = fatherName;
            BirthDate = birthDate;
        }

        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
