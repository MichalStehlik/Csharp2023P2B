using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Generics
{
    internal class Store<T> : IEquatable<Store<T>> where T : IEquatable<T>
    {
        public Store(T value)
        {
            Value = value;
        }

        public T Value { get; protected set; }

        public bool Equals(Store<T>? other)
        {
            return Value.Equals(other!.Value);
        }

        public T SetValue(T x)
        {
            Value = x;
            return Value;
        }
    }
}
