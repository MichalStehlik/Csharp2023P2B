using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// vlastnosti, dědičnost, zapouzdření

namespace C04Properties
{
    internal class Student : Human // potomek, dcera
    {
        public Student(string firstname, string lastname, string classname)
            : base(firstname, lastname)
        {
            // _firstname = 
            Classname = classname;
        }

        public string Classname { get; set; }
    }
}
