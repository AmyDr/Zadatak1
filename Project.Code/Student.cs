using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Code
//Student class which holds specific student properties (use inheritance)
{
    public class Student: Person //nasljeđivanje klase Person
    {
        public string Gpa { get; set; }
    }
}
