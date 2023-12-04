using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08Interface
{
    internal class Newspaper : IReadable
    {
        public int PageCount { get { return 8; } }

        public string Read()
        {
            return "Agáta Hanychová";
        }
    }
}
