using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08Interface
{
    internal class Reader
    {
        public Reader(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Read(IReadable source) 
        {
            return "Reading " + source.Read() + "(" + source.PageCount + ")";
        }
    }
}
