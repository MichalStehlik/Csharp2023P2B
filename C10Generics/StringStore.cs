using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Generics
{
    internal class StringStore
    {
        public StringStore(string value)
        {
            Value = value;
        }

        public string Value { get; protected set; }
        public string SetValue(string x)
        {
            Value = x;
            return Value;
        }
        public string Add(string x)
        {
            Value += x;
            return Value;
        }
    }
}
