using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05ExceptionPolymorph
{
    internal class MyRectangle
    {
        private double _x;

        public MyRectangle(double x)
        {
            X = x;
        }

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value <= 0)
                {
                    //throw new ArgumentOutOfRangeException("Hodnota je mimo očekávatelné parametry");
                    throw new RectangleException("Hodnota je mimo očekávatelné parametry");
                }
                _x = value;
            }
        }
    }
}

// https://learn.microsoft.com/en-us/dotnet/standard/exceptions/exception-class-and-properties
// https://learn.microsoft.com/en-us/dotnet/standard/exceptions/
