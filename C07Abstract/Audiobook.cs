using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07Abstract
{
    internal class Audiobook : Book
    {
        public double Length { get; set; }

        public override void Play() { Console.WriteLine("aaaaaa"); }
    }
}
