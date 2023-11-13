using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06Polymorphism
{
    internal class Animal : Object
    {
        public virtual string MakeSound() // lze override
        {
            return "...";
        }

        public override string ToString()
        {
            return "Common ";
        }
    }
}
