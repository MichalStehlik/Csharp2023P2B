using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08Interface
{
    internal interface IReadable
    {
        string Read();
        int PageCount { get; }
    }
}
