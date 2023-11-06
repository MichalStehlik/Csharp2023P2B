using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace C05ExceptionPolymorph
{
    internal class RectangleException : Exception
    {
        public RectangleException() :base() { }

        public RectangleException(string? message) : base(message)
        {
        }

        public RectangleException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RectangleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
