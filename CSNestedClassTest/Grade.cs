using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNestedClassTest
{
    public class Grade
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public string Class { get; set; }
        public int Number { get; set; }

        public Grade() { }

        public Grade(string newClass, int number)
        {
            Class = newClass;
            Number = number;
        }
    }
}
