using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04Properties
{
    internal class Human // předek, rodič, matka
    {
        // private string _firstname; // nepřístupně mimo, nedědí se
        protected string _firstname; // nepřístupný, ale dědí se
        //private string _lastname;

        public void SetFirstname(string fn)
        {
            _firstname = fn;
        }

        public string GetFirstname() { return _firstname; }

        public Human(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname
        {
            get { return _firstname; } // čtení dat
            set {
                if (value != "Adolf")
                {
                    _firstname = value;
                }
            } // nastavení dat
        }

        // prop + tab + tab
        public string Lastname { get; set; } // autoimplementovaná vlastnost
        // public string Lastname { get; private set; }

        public string Fullname { get { return Firstname + " " + Lastname; } }


    }
}
