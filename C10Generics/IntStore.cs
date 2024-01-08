using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Generics
{
    internal class IntStore
    {
        public IntStore(int value)
        {
            Value = value;
        }

        public int Value { get; protected set; }
        public int SetValue(int x)
        {
            Value = x;
            return Value;
        }
        public int Add(int x)
        {
            Value += x;
            return Value;
        }
    }
}
