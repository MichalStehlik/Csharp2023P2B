using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06Polymorphism
{
    internal class Measurement
    {
        // statický polymorfismus - přetížení
        public Measurement()
        {
            Value = 0;
        }
        public Measurement(int init = 0)
        {
            Value = init;
        }
        public Measurement(double init)
        {
            Value = (int)init;
        }
        public Measurement(int init, int multiplyer)
        {
            Value = init * multiplyer;
        }

        public int Value { get; private set; }

        public void Add(int increment) // přetížená metoda
        {
            Value += increment;
        }

        public void Add(double increment) // přetížená metoda
        {
            Value += (int)increment;
        }
    }
}
