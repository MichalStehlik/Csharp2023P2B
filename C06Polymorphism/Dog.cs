using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06Polymorphism
{
    internal class Dog : Animal
    {
        public override string MakeSound() // dynamický polymorfismus
            // override - překrýváme
            // new - přepisujeme
        {
            return "Haf";
        }

        public string MakeHappySound()
        {
            return "NafNaf";
        }
        public override string ToString()
        {
            return "Dog";
        }
    }
}
