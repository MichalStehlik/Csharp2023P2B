using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12Extension
{
    internal class Delegates
    {
        public Delegates(float a, float b)
        {
            A = a;
            B = b;
        }

        public float Do(MathOperation mop)
        {
            return mop(A, B);
        }

        // e => x + 1; // lambda // arrow function
        public float Addition(float a, float b) { return a + b; } // MathOperation
        public float Subtraction(float a, float b) { return a - b; }
        public float Multiplication(float a, float b) { return a * b; }
        public float Division(float a, float b) { return a / b; }
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
    }

    public delegate float MathOperation(float a, float b);
    // všechy funkce, které mají na vstupu dva float a vrací float
}
