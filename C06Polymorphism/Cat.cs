using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06Polymorphism
{
    internal class Cat: Animal
    {
        public new string MakeSound() // dynamický polymorfismus
                                           // override - překrýváme
                                           // new - přepisujeme
        {
            return "Mnau";
        }

        public string MakeAngrySound()
        {
            return "Mnaaaau";
        }
        public override string ToString()
        {
            return base.ToString() + "Cat"; // ToString z Animal + Cat
        }
    }
}
