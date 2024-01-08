using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Generics
{
    internal class DoubleStore
    {
        public DoubleStore(double value)
        {
            Value = value;
        }

        public double Value { get; protected set; }
        public double SetValue(double x)
        {
            Value = x;
            return Value;
        }
        public double Add(double x)
        {
            Value += x;
            return Value;
        }
    }
}
